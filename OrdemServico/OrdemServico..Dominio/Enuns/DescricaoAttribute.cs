using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdemServico.Dominio.Enuns
{
    public class DescricaoAttribute: Attribute
    {
        public readonly string Descricao;
        public DescricaoAttribute(string descricao)
        {
            Descricao = descricao;
        }
    }
}
