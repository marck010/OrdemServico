using CadastroDeMembros.Dominio.Configuracao;
using CadastroDeMembros.Dominio.Entidades;
using CadastroDeMembros.Dominio.Repositorios;
using CadastroDeMembros.Infraetrutura.Repositorios;
using System;
using System.Data;
using System.Text;
using System.Data.SqlServerCe;
using CadastroDeMembros.Dominio.Utils;
using System.Collections.Generic;
using System.Linq;
using EntidadeOrdemServico = CadastroDeMembros.Dominio.Entidades.OrdemServico;

namespace CadastroDeMembros.Infraetrutura
{
    public class RepositorioOrdemServico : RepositorioBase<EntidadeOrdemServico>, IRepositorioOrdemServico
    {
        public RepositorioOrdemServico(ILeitorDeConfiguracao leitorDeConfiguracao)
            : base(leitorDeConfiguracao){}

        public IEnumerable<EntidadeOrdemServico> PesquisarOrdens(string numeroOS, string cpf, int? IdSituacao)
        {
            var ordens = Contexto.Set<EntidadeOrdemServico>().AsQueryable();

            if (!String.IsNullOrWhiteSpace(numeroOS))
            {
                var numero = Convert.ToInt32(numeroOS);
                ordens = ordens.Where(ordem => ordem.Id == numero);
            }

            if (!string.IsNullOrWhiteSpace(cpf))
            {
                ordens = ordens.Where(ordem => ordem.Cliente != null && ordem.Cliente.CPF.Contains(cpf));
            }

            if (IdSituacao.HasValue)
            {
                ordens = ordens.Where(ordem => ordem.Situacao != null && ordem.Situacao.Id == IdSituacao);
            }

            return ordens;
        }
    
    }
}
