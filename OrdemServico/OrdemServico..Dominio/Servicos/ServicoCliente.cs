using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CadastroDeMembros.Dominio.Repositorios;
using CadastroDeMembros.Dominio.Entidades;
using CadastroDeMembros.Dominio.Validadores;
using CadastroDeMembros.Dominio.Excecoes;

namespace CadastroDeMembros.Dominio.Servicos
{
    public class ServicoCliente
    {
        private readonly IRepositorioCliente _repositorioCliente;
        private readonly IValidador<Cliente> _validador;

        public ServicoCliente(IRepositorioCliente repositorioCliente, IValidador<Cliente> validador)
        {
            _repositorioCliente = repositorioCliente;
            _validador = validador;
        }

        public void SalvarCliente(Cliente cliente)
        {
            var erros = _validador.Validar(cliente);
           if (erros.Count()>0)
           {
               var errosString = String.Join("\r\n", erros);
               throw new ErroDeValidacaoException(errosString);
           }
           if (cliente.Id > 0)
           {
               var clienteSalvo = _repositorioCliente.ObterPorId(cliente.Id);
               clienteSalvo.Nome = cliente.Nome;
               clienteSalvo.CPF = cliente.CPF;
               clienteSalvo.Telefone1 = cliente.Telefone1;
               clienteSalvo.Telefone2 = cliente.Telefone2;
               clienteSalvo.Email = cliente.Email;
               _repositorioCliente.Atualizar();
           }
           else
           {
               _repositorioCliente.Adicionar(cliente);
           }
        }
    }
}
