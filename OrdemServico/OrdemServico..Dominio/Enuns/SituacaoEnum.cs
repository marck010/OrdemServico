using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdemServico.Dominio.Enuns
{
    public enum SituacaoEnum
    {
        [Descricao("A Iniciar")]
        AIniciar =1,

        [Descricao("Em Andamento")]
        EmAndamento,

        [Descricao("Aguardando")]
        Aguardando,

        [Descricao("Finalizado")]
        Finalizado
    }
}
