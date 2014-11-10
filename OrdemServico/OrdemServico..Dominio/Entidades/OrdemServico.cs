using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDeMembros.Dominio.Entidades
{
    public class OrdemServico
    {
        public OrdemServico()
        {
            HistoricoSituacao = new List<HistoricoOrdemServico>();
        }

        public int              Id                 { get; set; }
        public String           Instrumento        { get; set; }
        public String           NumeroSerie        { get; set; }
        public String           ProblemaReclamado  { get; set; }
        public String           ServicoRealizado   { get; set; }
        public String           Observacao         { get; set; }
        public double?          Valor              { get; set; }

        public virtual Cliente Cliente { get; set; }
        public virtual int IdCliente { get; set; }

        public virtual Situacao Situacao { get; set; }
        public virtual int IdSituacao { get; set; }

        public DateTime?        PrevisaEntrega     { get; set; }
        public virtual List<HistoricoOrdemServico> HistoricoSituacao { get; set; }

    }       
}
