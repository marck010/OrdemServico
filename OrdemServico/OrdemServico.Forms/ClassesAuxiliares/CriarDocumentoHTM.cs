using CadastroDeMembros.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntidadeOrdemServico = CadastroDeMembros.Dominio.Entidades.OrdemServico;

namespace OrdemServico.Forms.ClassesAuxiliares
{
    public class CriarDocumentoHTML
    {
        public void ImprimirOrdem(EntidadeOrdemServico ordem, Cliente cliente)
        {
            WebBrowser webBrowser = new WebBrowser();
            string curDir = Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory.ToString());
            var caminhoDoTemplate = curDir.Replace("bin\\Debug", "OrdemTemplate.html");
            using (var arquivo = new StreamReader(File.Open(caminhoDoTemplate, FileMode.Open)))
            {
                var html = String.Format(
                                            arquivo.ReadToEnd(),
                                            ordem.Id.ToString("D4"),
                                            DateTime.Now.ToShortDateString(),
                                            cliente.Nome,
                                            cliente.CPF,
                                            cliente.Email,
                                            cliente.Telefone2,
                                            cliente.Telefone1,
                                            ordem.ProblemaReclamado,
                                            ordem.Observacao,
                                            ordem.Instrumento,
                                            ordem.NumeroSerie,
                                            ordem.PrevisaEntrega.HasValue?ordem.PrevisaEntrega.Value.ToShortDateString():String.Empty,
                                            ordem.ServicoRealizado,
                                            ordem.Valor
                                        );

                webBrowser.Navigate("about:blank");
                webBrowser.Document.Write(html);
                webBrowser.ShowPrintPreviewDialog();
            }
        }
    }
}
