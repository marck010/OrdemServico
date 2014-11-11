using CadastroDeMembros.Dominio.Entidades;
using CadastroDeMembros.Dominio.Validadores;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadeOrdemServico = CadastroDeMembros.Dominio.Entidades.OrdemServico;

namespace CadastroDeMembros.Infraetrutura.EntityFramework.Mapeamentos
{
    public class HistoricoOrdemServicoConfiguration : EntityTypeConfiguration<HistoricoOrdemServico>
    {
        public HistoricoOrdemServicoConfiguration()
        {
           ToTable("OrdemServicoSituacao");

           HasKey(entidade => entidade.Id);
           Property(entidade => entidade.Observacao);
           Property(entidade => entidade.DataCriacao);

           HasRequired(entidade => entidade.OrdemServico)
               .WithMany()
               .HasForeignKey(m => m.IdOrdemServico);

           HasRequired(entidade => entidade.Situacao)
               .WithMany()
               .HasForeignKey(m => m.IdSituacao);
        }
    }
}
