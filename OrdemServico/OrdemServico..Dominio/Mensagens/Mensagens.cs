using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDeMembros.Dominio.Mensagens
{
    public static class Mensagens
    {
        public const string CampoObrigatorio = "Campo {0} Obrigatório";
        public const string CampoInvalido = "O Valor do Campo {0} é invalido";
        public const String FormatoRegistroInvalido = @"Formato de {0} inválido(a).";

        public static string Argumentos(this string mensagem,  params string[] parametro)
        {
            return String.Format(mensagem, parametro);
        }
    }
}
