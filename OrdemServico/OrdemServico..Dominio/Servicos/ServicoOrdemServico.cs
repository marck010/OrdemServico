using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CadastroDeMembros.Dominio.Repositorios;
using CadastroDeMembros.Dominio.Entidades;
using CadastroDeMembros.Dominio.Validadores;
using CadastroDeMembros.Dominio.Excecoes;
using OrdemServico.Dominio.Enuns;
using EntidadeOrdemServico = CadastroDeMembros.Dominio.Entidades.OrdemServico;

namespace CadastroDeMembros.Dominio.Servicos
{
    public class ServicoOrdemServico
    {
        private readonly IRepositorioOrdemServico _repositorioOrdemServico;
        private readonly IRepositorioSituacao _repositorioSituacao;
        private readonly IValidador<EntidadeOrdemServico> _validador;

        public ServicoOrdemServico(IRepositorioOrdemServico repositorioOrdemServico, IRepositorioSituacao repositorioSituacao, IValidador<EntidadeOrdemServico> validador)
        {
            _repositorioOrdemServico = repositorioOrdemServico;
            _repositorioSituacao = repositorioSituacao;
            _validador = validador;
        }

        public void SalvarOrdemServico(EntidadeOrdemServico ordem)
        {
            var erros = _validador.Validar(ordem);
            if (erros.Count() > 0)
            {
                var errosString = String.Join("\r\n", erros);
                throw new ErroDeValidacaoException(errosString);
            }

            if (ordem.Id > 0)
            {
                var OrdemSalva = _repositorioOrdemServico.ObterPorId(ordem.Id);
                OrdemSalva.Instrumento = ordem.Instrumento;
                OrdemSalva.NumeroSerie = ordem.NumeroSerie;
                OrdemSalva.Observacao = ordem.Observacao;
                OrdemSalva.PrevisaEntrega = ordem.PrevisaEntrega;
                OrdemSalva.ProblemaReclamado = ordem.ProblemaReclamado;
                OrdemSalva.ServicoRealizado = ordem.ServicoRealizado;
                OrdemSalva.IdSituacao = ordem.IdSituacao;
                OrdemSalva.IdCliente = ordem.IdCliente;
                _repositorioOrdemServico.Atualizar();
            }
            else
            {
                ordem.IdSituacao = (int)SituacaoEnum.AIniciar;
                _repositorioOrdemServico.Adicionar(ordem);
            }
        }

        public void AlterarSituacaoOrdemServico(HistoricoOrdemServico historico)
        {
            var OrdemSalva = _repositorioOrdemServico.ObterPorId(historico.IdOrdemServico);

            OrdemSalva.HistoricoSituacao.Add(historico);
            OrdemSalva.IdSituacao = historico.IdSituacao;
            _repositorioOrdemServico.Atualizar();
        }
    }
}
