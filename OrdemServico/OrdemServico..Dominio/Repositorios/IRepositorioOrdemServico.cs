using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CadastroDeMembros.Dominio.Entidades;
using System.Data;
using EntidadeOrdemServico = CadastroDeMembros.Dominio.Entidades.OrdemServico;

namespace CadastroDeMembros.Dominio.Repositorios
{
    public interface IRepositorioOrdemServico : IRepositorioBase<EntidadeOrdemServico>
    {
        IEnumerable<EntidadeOrdemServico> PesquisarOrdens(string numeroOS, string cpf, int? IdSituacao);
    }
}
