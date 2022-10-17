using InjecaoDependenciaExemplo.Interfaces;

namespace InjecaoDependenciaExemplo.Services
{
    public class ExemploService
    {
        public IExemploTransient TransientExemplo { get; }
        public IExemploScoped ScopedExemplo { get; }
        public IExemploSingleton SingletonExemplo { get; }
        public IExemploSingletonInstance SingletonInstanceExemplo { get; }

        public ExemploService(IExemploTransient transientExemplo,
            IExemploScoped scopedExemplo,
            IExemploSingleton singletonExemplo,
            IExemploSingletonInstance instanceExemplo)
        {
            TransientExemplo = transientExemplo;
            ScopedExemplo = scopedExemplo;
            SingletonExemplo = singletonExemplo;
            SingletonInstanceExemplo = instanceExemplo;
        }
    }
}
