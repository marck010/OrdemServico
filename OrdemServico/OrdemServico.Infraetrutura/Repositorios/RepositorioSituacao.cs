using CadastroDeMembros.Dominio.Configuracao;
using CadastroDeMembros.Dominio.Entidades;
using CadastroDeMembros.Dominio.Repositorios;
using CadastroDeMembros.Infraetrutura.Repositorios;
using System;
using System.Data;
using System.Text;
using System.Data.SqlServerCe;
using CadastroDeMembros.Dominio.Utils;

namespace CadastroDeMembros.Infraetrutura
{
    public class RepositorioSituacao : RepositorioBase<Situacao>, IRepositorioSituacao
    {
        public RepositorioSituacao(ILeitorDeConfiguracao leitorDeConfiguracao)
            : base(leitorDeConfiguracao)
        {
        }
    }
}
