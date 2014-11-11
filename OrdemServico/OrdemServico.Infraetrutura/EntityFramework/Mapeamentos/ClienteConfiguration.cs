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
    public class ClienteConfiguration : EntityTypeConfiguration<Cliente>
    {
        public ClienteConfiguration()
        {
            ToTable("Cliente");

            HasKey(entidade => entidade.Id);
            Property(entidade => entidade.Nome)
                  .HasMaxLength(ValidadorCliente.TamanhoMaximoCampoNome);

            Property(entidade => entidade.Telefone1);
            Property(entidade => entidade.Telefone2);
            Property(entidade => entidade.Email);
            Property(entidade => entidade.CPF);
        }
    }
}
