using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDeMembros.Dominio.Repositorios
{
    public interface IRepositorioBase<T>{

        void Adicionar(T entidade);
        void Atualizar();
        IQueryable<T> ObterTodos();
        T ObterPorId(int id);
    }
}
