using CadastroDeMembros.Dominio.Configuracao;
using CadastroDeMembros.Dominio.Entidades;
using CadastroDeMembros.Dominio.Repositorios;
using CadastroDeMembros.Infraetrutura.Repositorios;
using System;
using System.Linq;
using System.Data;
using System.Text;
using System.Data.SqlServerCe;
using CadastroDeMembros.Dominio.Utils;
using System.Collections.Generic;

namespace CadastroDeMembros.Infraetrutura
{
    public class RepositorioCliente : RepositorioBase<Cliente>, IRepositorioCliente
    {
        public RepositorioCliente(ILeitorDeConfiguracao leitorDeConfiguracao)
            : base(leitorDeConfiguracao){}

        public IEnumerable<Cliente> PesquisarClientes(string nome, string telefone, string celular)
        {
            var membros = Contexto.Set<Cliente>().AsQueryable();

            if (!string.IsNullOrWhiteSpace(nome))
            {
                membros = membros.Where(membro => membro.Nome.Contains(nome));
            }

            if (!string.IsNullOrWhiteSpace(telefone))
            {
                membros = membros.Where(membro => membro.Telefone1.Contains(telefone));
            }

            if (!string.IsNullOrWhiteSpace(celular))
            {
                membros = membros.Where(membro => membro.Telefone2.Contains(celular));
            }

            return membros;
        }

        public Cliente ObterPorCPF(string cpf)
        {
            return Contexto.Set<Cliente>().SingleOrDefault(cliente => cliente.CPF == cpf);
        }
    }
}
