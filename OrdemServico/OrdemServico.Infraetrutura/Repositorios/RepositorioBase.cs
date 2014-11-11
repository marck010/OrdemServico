using CadastroDeMembros.Dominio.Configuracao;
using CadastroDeMembros.Dominio.Repositorios;
using System.Data.Entity;
using CadastroDeMembros.Dominio.Entidades;
using CadastroDeMembros.Infraetrutura.EntityFramework;
using System.Linq;

namespace CadastroDeMembros.Infraetrutura.Repositorios
{
    public class RepositorioBase<T> : IRepositorioBase<T> where T:class
    {
        public readonly ContextoEntityFramework Contexto;

        public RepositorioBase(ILeitorDeConfiguracao leitorDeConfiguracao) 
        {
            Contexto = new ContextoEntityFramework(leitorDeConfiguracao);
        }

        public void Adicionar(T entidade)
        {
            Contexto.Set<T>().Add(entidade);
            Contexto.SaveChanges();
        }

        public void Atualizar()
        {
           Contexto.SaveChanges();
        }
            
        public IQueryable<T> ObterTodos()
        {
            return Contexto.Set<T>().AsQueryable();
        }

        public T ObterPorId(int id)
        {
            return Contexto.Set<T>().Find(id);
        }
    }
}
