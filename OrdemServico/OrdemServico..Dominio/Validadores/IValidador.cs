using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDeMembros.Dominio.Validadores
{
    public interface IValidador<T>
    {
        IEnumerable<String> Validar(T entidade);
    }
}
