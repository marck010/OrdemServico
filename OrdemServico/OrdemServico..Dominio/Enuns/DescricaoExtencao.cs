using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdemServico.Dominio.Enuns
{
    public static class DescricaoExtencao
    {
        public static string Descricao<T>(this T value)
        {
            var field = value.GetType().GetField(value.ToString());

            var attributes = (DescricaoAttribute[])field.GetCustomAttributes(typeof(DescricaoAttribute), false);

            if (attributes != null && attributes.Length > 0)
            {
                return attributes[0].Descricao;
            }
            else
            {
                return value.ToString();
            }
        }
    }
}
