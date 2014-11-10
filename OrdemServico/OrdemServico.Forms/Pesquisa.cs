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
using OrdemServico.InjetorDependencia;
using OrdemServico.Forms.ClassesAuxiliares;
using EntidadeOrdemServico = CadastroDeMembros.Dominio.Entidades.OrdemServico;
using OrdemServico.Dominio.Enuns;

namespace OrdemServico.Forms
{
    public partial class form_Pesquisa : Form
    {
        #region Variáveis de instância

        private readonly IRepositorioOrdemServico _repositorioOrdemServico;
        private readonly IRepositorioSituacao _repositorioSituacao;

        #endregion

        #region Construtor

        public form_Pesquisa()
        {
            _repositorioOrdemServico = IOC.Resolver<IRepositorioOrdemServico>();
            _repositorioSituacao = IOC.Resolver<IRepositorioSituacao>();

            InitializeComponent();
            CarregarDados();
        }

        #endregion

        #region Eventos

        private void menuCadastrarCliente_Click(object sender, EventArgs e)
        {
            new form_CadastroCliente(this).Show();
        }

        private void btn_Pesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                ConfigurarCampoMask(txt_CPF);

                var idSituacao = cb_Situacao.ValorSelecionado().ToInt32Nullable();
                string cpf = txt_CPF.Text;
                string numeroOs = txt_NumeroOS.Text;

                var ordens = _repositorioOrdemServico.PesquisarOrdens(numeroOs, cpf, idSituacao);
                CarregarGrid(ordens);

            }
            catch (Exception ex)
            {
                MessageBox.Show(String.Format("Ocorreu um erro na aplicação. \r\nErro:{0}", ex.Message), "Erro");
            }
        }

        private void dgv_Membros_DoubleClick(object sender, EventArgs e)
        {
            var grid = (DataGridView)sender;
            var idOrdem = grid.CurrentRow.Cells[0].Value.ToInt32();
            new form_AlterarSituacaoOrdemServico(idOrdem, this).Show();
        }

        #endregion

        #region Métodos

        private void ConfigurarCampoMask(MaskedTextBox campoMascara)
        {
            campoMascara.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            if (!String.IsNullOrWhiteSpace(campoMascara.Text))
            {
                campoMascara.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
            }
        }

        public void CarregarDados()
        {
            var ordens = _repositorioOrdemServico.ObterTodos();
            CarregarGrid(ordens);
            CarregarSituacoes();
        }

        private void CarregarGrid(IEnumerable<EntidadeOrdemServico> ordens)
        {
            var objetoGrid = ordens.Select(ordem =>
                new
                {
                    NumeroOS = ordem.Id.ToString("D4"),
                    Cliente = ordem.Cliente.Nome,
                    Previsao = ordem.PrevisaEntrega.HasValue ? ordem.PrevisaEntrega.Value.ToShortDateString() : String.Empty,
                    Situacao = ordem.Situacao.Nome

                }).ToList();

            dgv_Membros.DataSource = objetoGrid;
            dgv_Membros.Columns[0].HeaderText = "Nº da OS";

            dgv_Membros.Columns[1].HeaderText = "Cliente";
            dgv_Membros.Columns[1].Width = 177;

            dgv_Membros.Columns[2].HeaderText = "Previsão de Entrega";

            dgv_Membros.Columns[3].HeaderText = "Situação da Ordem";
        }

        private void CarregarSituacoes()
        {
            var situacoes = (SituacaoEnum[])Enum.GetValues(typeof(SituacaoEnum));
            var itens = situacoes.Select(item => new ComboBoxItem() { Value = ((int)item).ToString(), Text = item.Descricao() }).ToList();
            cb_Situacao.AdcionarItens(itens);
        }

        #endregion
    }
}
