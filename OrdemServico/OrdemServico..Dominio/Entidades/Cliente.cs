using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDeMembros.Dominio.Entidades
{
    public class Cliente
    {
        public int                          Id            { get; set; }
        public String                       Nome          { get; set; }
        public String                       Telefone1     { get; set; }
        public String                       Telefone2     { get; set; }
        public String                       Email         { get; set; }
        public String                       CPF           { get; set; }
        //public virtual IList<OrdemServico>  OrdensServico { get; set; }
    }
}
