using CadastroDeMembros.Dominio.Entidades;
using CadastroDeMembros.Dominio.Validadores;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDeMembros.Infraetrutura.EntityFramework.Mapeamentos
{
    public class SituacaoConfiguration : EntityTypeConfiguration<Situacao>
    {
        public SituacaoConfiguration()
        {
            ToTable("Situacao");

            HasKey(entidade => entidade.Id);
            Property(entidade => entidade.Nome);
            Property(entidade => entidade.Descricao);
        }
    }
}
