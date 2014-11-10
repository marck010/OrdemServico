using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDeMembros.Dominio.Entidades
{
    public class HistoricoOrdemServico
    {
        public int                  Id                 { get; set; }
        public virtual OrdemServico OrdemServico       { get; set; }
        public int                  IdOrdemServico     { get; set; }
        public virtual Situacao     Situacao           { get; set; }
        public int                  IdSituacao         { get; set; }
        public String               Observacao         { get; set; }
        public DateTime?            DataCriacao        { get; set; }
    }       
}
