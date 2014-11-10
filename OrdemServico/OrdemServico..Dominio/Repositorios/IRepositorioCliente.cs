using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CadastroDeMembros.Dominio.Entidades;
using System.Data;

namespace CadastroDeMembros.Dominio.Repositorios
{
    public interface IRepositorioCliente : IRepositorioBase<Cliente>    {

        IEnumerable<Cliente> PesquisarClientes(string nome, string telefone, string celular);
        Cliente ObterPorCPF(string cpf);
    }
}
