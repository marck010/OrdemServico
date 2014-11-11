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
    public class OrdemServicoConfiguration : EntityTypeConfiguration<EntidadeOrdemServico>
    {
        public OrdemServicoConfiguration()
        {
           ToTable("OrdemServico");
           HasKey(entidade => entidade.Id);

           Property(entidade => entidade.Instrumento);
           Property(entidade => entidade.NumeroSerie);
           Property(entidade => entidade.ProblemaReclamado);
           Property(entidade => entidade.ServicoRealizado);
           Property(entidade => entidade.Observacao);
           Property(entidade => entidade.Valor);
           Property(entidade => entidade.PrevisaEntrega);

           HasRequired(entidade => entidade.Cliente)
               .WithMany()
               .HasForeignKey(m => m.IdCliente);

           HasRequired(entidade => entidade.Situacao)
               .WithMany()
               .HasForeignKey(m => m.IdSituacao);

           HasMany(entidade => entidade.HistoricoSituacao)
               .WithRequired(historico=>historico.OrdemServico)
               .HasForeignKey(historico => historico.IdOrdemServico)
               .WillCascadeOnDelete();

        }
    }
}
