using CadastroDeMembros.Dominio.Entidades;
using CadastroDeMembros.Dominio.Mensagens;
using CadastroDeMembros.Dominio.Servicos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CadastroDeMembros.Dominio.Utils;
using CadastroDeMembros.Dominio.Repositorios;
using OrdemServico.Forms.ClassesAuxiliares;
using OrdemServico.InjetorDependencia;
using CadastroDeMembros.Dominio.Configuracao;
using Microsoft.Office.Interop.Word;
using EntidadeOrdemServico = CadastroDeMembros.Dominio.Entidades.OrdemServico;

namespace OrdemServico.Forms
{
    public partial class form_CadastroCliente : Form
    {
        #region Variáveis de instância

        private int? IdCliente { get; set; }
        private int? IdOrdem { get; set; }
        private readonly ServicoCliente _servicoCliente;
        private readonly ServicoOrdemServico _servicoOrdemServico;
        private form_Pesquisa _formPesquisa;
        private readonly IRepositorioCliente _repositorioCliente;
        private readonly IRepositorioSituacao _repositorioSituacao;
        private readonly IRepositorioOrdemServico _repositorioOrdem;

        #endregion

        #region Construtores

        public form_CadastroCliente(form_Pesquisa formPesquisa)
        {
            _formPesquisa = formPesquisa;
            _servicoCliente = IOC.Resolver<ServicoCliente>();
            _servicoOrdemServico = IOC.Resolver<ServicoOrdemServico>();

            _repositorioSituacao = IOC.Resolver<IRepositorioSituacao>();
            _repositorioCliente = IOC.Resolver<IRepositorioCliente>();
            _repositorioOrdem = IOC.Resolver<IRepositorioOrdemServico>();

            InitializeComponent();
            CarregarComboBoxs();
        }

        public form_CadastroCliente(int idOrdem, form_Pesquisa formPesquisa)
            : this(formPesquisa)
        {
            var ordem = _repositorioOrdem.ObterPorId(idOrdem);
            CarregarCampos(ordem);
        }

        #endregion

        #region Eventos

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            try
            {

                ConfigurarCampoMask(txt_Telefone);
                ConfigurarCampoMask(txt_Celular);
                ConfigurarCampoMask(txt_DataEntrega);

                var erros = ValidarCampos();

                if (erros.Count() > 0)
                {
                    string errosString = String.Join("\r\n", erros);
                    MessageBox.Show(errosString, "Erro");
                    return;
                }

                var cliente = new Cliente();

                cliente.Id = IdCliente ?? 0;
                cliente.Nome = txt_Nome.Text;
                cliente.Telefone1 = txt_Telefone.Text.SomenteDigitos();
                cliente.Telefone2 = txt_Celular.Text.SomenteDigitos();
                cliente.Email = txt_Email.Text;
                cliente.CPF = txt_CPF.Text.SomenteDigitos();
                _servicoCliente.SalvarCliente(cliente);

                var ordemServico = new EntidadeOrdemServico();

                ordemServico.Instrumento = txt_Instrumento.Text;
                ordemServico.NumeroSerie = txt_NumeroSerial.Text;
                ordemServico.ProblemaReclamado = txt_ProblemaReclamado.Text;
                ordemServico.PrevisaEntrega = txt_DataEntrega.Text.ToDateTimeNullable();
                ordemServico.ServicoRealizado = txt_Servicos.Text;
                ordemServico.Observacao = txt_Observacao.Text;
                ordemServico.Valor = !String.IsNullOrWhiteSpace(txt_Valor.Text) ? Double.Parse(txt_Valor.Text) : new double?();
                ordemServico.IdCliente = cliente.Id;

                _servicoOrdemServico.SalvarOrdemServico(ordemServico);

                var imprimir = new CriarDocumentoHTML();
                imprimir.ImprimirOrdem(ordemServico, cliente);

            }
            catch (Exception ex)
            {
                MessageBox.Show(String.Format("Ocorreu um erro na aplicação. \r\nErro:{0}", ex.Message), "Erro");
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_CPF_TextChanged(object sender, EventArgs e)
        {
            var cpf = txt_CPF.Text.SomenteDigitos();
            var cliente = _repositorioCliente.ObterPorCPF(cpf);
            if (cliente != null)
            {
                CarregarCamposClinte(cliente);
            }
        }

        #endregion

        #region Métodos

        private void CarregarCamposClinte(Cliente cliente)
        {
            IdCliente = cliente.Id;
            txt_Nome.Text = cliente.Nome;
            txt_Telefone.Text = cliente.Telefone1;
            txt_Celular.Text = cliente.Telefone2;
            txt_Email.Text = cliente.Email;
            txt_CPF.Text = cliente.CPF;
        }
        private void CarregarCamposOrdem(EntidadeOrdemServico ordem)
        {
            IdOrdem = ordem.Id;
            txt_ProblemaReclamado.Text = ordem.ProblemaReclamado;
            txt_Servicos.Text = ordem.ServicoRealizado;
            txt_Observacao.Text = ordem.Observacao;
            txt_Instrumento.Text = ordem.Instrumento;
            txt_NumeroSerial.Text = ordem.NumeroSerie;
            txt_DataEntrega.Text = ordem.PrevisaEntrega.HasValue ? ordem.PrevisaEntrega.Value.ToShortDateString() : string.Empty;
            txt_Valor.Text = ordem.Valor.HasValue ? ordem.Valor.Value.ToString("N2") : String.Empty;
        }
        private void CarregarCampos(EntidadeOrdemServico ordemServico)
        {
            CarregarCamposClinte(ordemServico.Cliente);
            CarregarCamposOrdem(ordemServico);
        }

        private void CarregarComboBoxs()
        {
            CarregarSituacoes();
        }

        private void CarregarSituacoes()
        {
            var situacoes = _repositorioSituacao.ObterTodos();
            var itens = situacoes.Select(item => new ComboBoxItem() { Value = item.Id.ToString(), Text = item.Nome }).ToList();
        }

        private bool DataNaoEhValida(string valor)
        {
            if (!String.IsNullOrWhiteSpace(valor))
            {
                DateTime data;
                return !DateTime.TryParse(valor, out data);
            }
            return false;
        }

        private void ConfigurarCampoMask(MaskedTextBox campoMascara)
        {
            campoMascara.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            if (!String.IsNullOrWhiteSpace(campoMascara.Text))
            {
                campoMascara.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
            }
        }

        private IEnumerable<String> ValidarCampos()
        {
            if (DataNaoEhValida(txt_DataEntrega.Text))
            {
                yield return Mensagens.CampoInvalido.Argumentos("Previsão de Entrega");
            }
        }
        #endregion

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            Limpar(gp_DadosOrdemServico.Controls);
            Limpar(gp_DadosPessoais.Controls);

        }

        private void Limpar(Control.ControlCollection components)
        {
            foreach (var item in components)
            {
                if (item is TextBoxBase)
                {
                    ((TextBoxBase)item).Text = string.Empty;
                }
            }
        }

        private void form_CadastroCliente_FormClosed(object sender, FormClosedEventArgs e)
        {
           _formPesquisa.CarregarDados();
        }
    }
}
