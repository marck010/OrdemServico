using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using CadastroDeMembros.Dominio.Configuracao;
namespace CadastroDeMembros.Infraetrutura.Configuracao
{
    public class LeitorDeConfiguracao : ILeitorDeConfiguracao
    {
        public String ObterStringDeConexao()
        {
            return ConfigurationManager.ConnectionStrings["BancoOrdemServico"].ToString();
        }

        public String ObterCaminhoDoArquivoTamplate()
        {
            return ConfigurationManager.AppSettings["CaminhoArquivoTamplate"].ToString();
        }
    }
}
