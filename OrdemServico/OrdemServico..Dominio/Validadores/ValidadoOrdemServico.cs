using CadastroDeMembros.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CadastroDeMembros.Dominio.Mensagens;
using CadastroDeMembros.Dominio.Utils;
using System.Text.RegularExpressions;
using MensagensGerais = CadastroDeMembros.Dominio.Mensagens.Mensagens;
using EntidadeOrdemServico = CadastroDeMembros.Dominio.Entidades.OrdemServico;

namespace CadastroDeMembros.Dominio.Validadores
{
    public class ValidadoOrdemServico : IValidador<EntidadeOrdemServico>
    {
        public const int TamanhoMaximoCampoNome = 100;
        public const int TamanhoMaximoCampoRG = 15;
        public const int TamanhoMaximoCampoCPF = 11;
        public const int TamanhoMaximoCampoTelefone = 11;
        public const int TamanhoMaximoCampoEmail = 100;

        public IEnumerable<String> Validar(EntidadeOrdemServico membro)
        {
           return Enumerable.Empty<String>();
        }
    }
}
