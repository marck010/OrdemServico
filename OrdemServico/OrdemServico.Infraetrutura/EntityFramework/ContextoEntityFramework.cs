using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CadastroDeMembros.Dominio.Entidades;
using CadastroDeMembros.Dominio.Configuracao;
using CadastroDeMembros.Dominio.Repositorios;
using CadastroDeMembros.Infraetrutura.EntityFramework.Mapeamentos;

namespace CadastroDeMembros.Infraetrutura.EntityFramework
{
    public class ContextoEntityFramework:DbContext
    {
        public ContextoEntityFramework(ILeitorDeConfiguracao leitorDeConfiguracao)
                : base(leitorDeConfiguracao.ObterStringDeConexao()) { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new OrdemServicoConfiguration());
            modelBuilder.Configurations.Add(new ClienteConfiguration());
            modelBuilder.Configurations.Add(new SituacaoConfiguration());
            modelBuilder.Configurations.Add(new HistoricoOrdemServicoConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}
