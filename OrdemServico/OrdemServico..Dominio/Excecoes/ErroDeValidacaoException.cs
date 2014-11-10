using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDeMembros.Dominio.Excecoes
{
    public class ErroDeValidacaoException:Exception
    {
        public ErroDeValidacaoException(string mensagem):base(mensagem)
        {
                
        }
    }
}
