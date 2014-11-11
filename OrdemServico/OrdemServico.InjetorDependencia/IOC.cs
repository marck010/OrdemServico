using CadastroDeMembros.Dominio.Configuracao;
using CadastroDeMembros.Dominio.Entidades;
using CadastroDeMembros.Dominio.Repositorios;
using CadastroDeMembros.Dominio.Servicos;
using CadastroDeMembros.Dominio.Validadores;
using CadastroDeMembros.Infraetrutura;
using CadastroDeMembros.Infraetrutura.Configuracao;
using CadastroDeMembros.Infraetrutura.Repositorios;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdemServico.InjetorDependencia
{
    public class IOC
    {
        private static IWindsorContainer _container;

        public static void Configurar()
        {
            _container = new WindsorContainer();
            _container.Register(Component.For<IRepositorioOrdemServico>().ImplementedBy<RepositorioOrdemServico>())
                      .Register(Component.For<IRepositorioCliente>().ImplementedBy<RepositorioCliente>())
                      .Register(Component.For<IRepositorioSituacao>().ImplementedBy<RepositorioSituacao>())
                      .Register(Component.For<ILeitorDeConfiguracao>().ImplementedBy<LeitorDeConfiguracao>())
                      .Register(Component.For<ServicoOrdemServico>().ImplementedBy<ServicoOrdemServico>())
                      .Register(Component.For<IValidador<Cliente>>().ImplementedBy<ValidadorCliente>())
                      .Register(Component.For<IValidador<CadastroDeMembros.Dominio.Entidades.OrdemServico>>().ImplementedBy<ValidadoOrdemServico>())
                      .Register(Component.For<ServicoCliente>().ImplementedBy<ServicoCliente>());
        }

        public static T Resolver<T>()
        {
            return _container.Resolve<T>();
        }
    }
}
