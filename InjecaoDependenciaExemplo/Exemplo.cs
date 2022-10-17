using InjecaoDependenciaExemplo.Interfaces;

namespace InjecaoDependenciaExemplo
{
    public class Exemplo : IExemploTransient, IExemploScoped, IExemploSingleton, IExemploSingletonInstance
    {
        Guid _guid;
        public Exemplo() : this(Guid.NewGuid())
        {

        }

        public Exemplo(Guid guid)
        {
            _guid = guid;
        }

        public Guid ExemploId => _guid;
    }
}
