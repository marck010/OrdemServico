using CadastroDeMembros.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CadastroDeMembros.Dominio.Mensagens;
using CadastroDeMembros.Dominio.Utils;
using MensagensGerais = CadastroDeMembros.Dominio.Mensagens.Mensagens;
using System.Text.RegularExpressions;

namespace CadastroDeMembros.Dominio.Validadores
{
    public class ValidadorCliente : IValidador<Cliente>
    {
        public const int TamanhoMaximoCampoNome = 100;
        public const int TamanhoMaximoCampoCPF = 11;
        public const int TamanhoMaximoCampoTelefone = 11;
        public const int TamanhoMaximoCampoEmail = 100;

        public IEnumerable<String> Validar(Cliente membro)
        {
            if (String.IsNullOrWhiteSpace(membro.Nome))
            {
                yield return MensagensGerais.CampoObrigatorio.Argumentos("Nome");
            }
            if (String.IsNullOrWhiteSpace(membro.CPF))
            {
                yield return MensagensGerais.CampoObrigatorio.Argumentos("CPF");
            }
            else if (!CPFValido(membro.CPF))
            {
                yield return MensagensGerais.CampoInvalido.Argumentos("CPF");
            }

            if (!EmailEhValido(membro.Email))
            {
                yield return MensagensGerais.CampoInvalido.Argumentos("Email");
            }
        }

        private bool EmailEhValido(string email)
        {
            email = email.ToLower();
            string padrao = @"^[_a-z0-9-]+(\.[_a-z0-9-]+)*@[a-z0-9-]+(\.[a-z0-9-]+)*(\.[a-z]{2,4})$";
            return Regex.IsMatch(email, padrao);
        }

        private bool CPFValido(string cpf)
        {
            string valor = cpf.SomenteDigitos();

            if (valor.Length != 11)
            {
                return false;
            }
            int[] numeros = new int[11];
            for (int i = 0; i < 11; i++)
            {
                numeros[i] = int.Parse(valor[i].ToString());
            }

            int soma = 0;

            for (int i = 0; i < 9; i++)
            {
                soma += (10 - i) * numeros[i];
            }

            int resultado = soma % 11;

            if (resultado == 1 || resultado == 0)
            {
                if (numeros[9] != 0)
                {
                    return false;
                }
            }

            else if (numeros[9] != 11 - resultado)
            {
                return false;
            }

            soma = 0;

            for (int i = 0; i < 10; i++)
            {
                soma += (11 - i) * numeros[i];
            }

            resultado = soma % 11;

            if (resultado == 1 || resultado == 0)
            {
                if (numeros[10] != 0)
                {
                    return false;
                }
            }

            else
            {

                if (numeros[10] != 11 - resultado)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
