using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CadastroDeMembros.Dominio.Utils
{
    public static class StringUtil
    {
        public static string SomenteDigitos(this string original)
        {
            return new Regex("[^0-9]").Replace(original, string.Empty);
        }
        public static string SemAcentuacao(this string original)
        {
            return original == null ? null :
                Encoding.UTF8.GetString(Encoding.GetEncoding("ISO-8859-8").GetBytes(original));
        }
    }
}
