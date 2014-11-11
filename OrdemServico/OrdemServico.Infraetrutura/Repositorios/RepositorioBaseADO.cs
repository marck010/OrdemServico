using CadastroDeMembros.Dominio.Configuracao;
using CadastroDeMembros.Dominio.Repositorios;
using System;
using System.Data.SqlServerCe;


namespace CadastroDeMembros.Infraetrutura.Repositorios
{
    public class RepositorioBaseADO:IRepositorioBaseADO
    {
        public readonly SqlCeConnection _conexao;
        public SqlCeCommand Comando {get;set;}
        private ILeitorDeConfiguracao _leitorDeConfiguracao;

        public RepositorioBaseADO(ILeitorDeConfiguracao leitorDeConfiguracao)
        {
            _leitorDeConfiguracao = leitorDeConfiguracao;  
            var stringConexao = _leitorDeConfiguracao.ObterStringDeConexao();
            _conexao = new SqlCeConnection(stringConexao);
        }

        public void ExecutarComando()
        {
            try
            {
                _conexao.Open();
                Comando.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }

            finally {
                _conexao.Close();
            }
        }
    }
}
