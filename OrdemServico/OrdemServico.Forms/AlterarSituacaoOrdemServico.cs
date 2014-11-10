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
using OrdemServico.Dominio.Enuns;

namespace OrdemServico.Forms
{
    public partial class form_AlterarSituacaoOrdemServico : Form
    {
        #region Variáveis de instância

        private int? IdCliente { get; set; }
        private int? IdOrdem { get; set; }
        private readonly ServicoOrdemServico _servicoOrdemServico;
        private readonly form_Pesquisa _formPesquisa;
        #endregion

        #region Construtores

        public form_AlterarSituacaoOrdemServico(form_Pesquisa formPesquisa)
        {
            _formPesquisa = formPesquisa;
            _servicoOrdemServico = IOC.Resolver<ServicoOrdemServico>();

            InitializeComponent();
            CarregarComboBoxs();
        }

        public form_AlterarSituacaoOrdemServico(int idOrdem, form_Pesquisa formPesquisa)
            : this(formPesquisa)
        {
            IdOrdem = idOrdem;
        }

        #endregion

        #region Eventos

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            try
            {
                var idSituacao = cb_Situacao.ValorSelecionado().ToInt32Nullable();
                if (idSituacao.HasValue)
                {
                 var ordemSituacao =    new HistoricoOrdemServico()
                                            {
                                                IdSituacao = idSituacao.Value,
                                                IdOrdemServico = IdOrdem.Value,
                                                Observacao = txt_Observacao.Text
                                            };

                 _servicoOrdemServico.AlterarSituacaoOrdemServico(ordemSituacao);
                }
                else
                {
                    MessageBox.Show(Mensagens.CampoObrigatorio.Argumentos("Situação"), "Erro");
                }
                _formPesquisa.CarregarDados();
                this.Close();
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

        #endregion

        #region Métodos

      
        private void CarregarComboBoxs()
        {
            CarregarSituacoes();
        }

        private void CarregarSituacoes()
        {
            var situacoes = (SituacaoEnum[])Enum.GetValues(typeof(SituacaoEnum));
            var itens = situacoes.Select(item => new ComboBoxItem() { Value = ((int)item).ToString(), Text = item.Descricao() }).ToList();
            cb_Situacao.AdcionarItens(itens);
        }
      
        #endregion

        private void form_AlterarSituacaoOrdemServico_FormClosed(object sender, FormClosedEventArgs e)
        {
            _formPesquisa.CarregarDados();
        }
    }
}
