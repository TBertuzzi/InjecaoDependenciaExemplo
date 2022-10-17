namespace InjecaoDependenciaExemplo.Interfaces
{

    public interface IExemplo
    {
        Guid ExemploId { get; }
    }

    public interface IExemploTransient : IExemplo
    {
    }

    public interface IExemploScoped : IExemplo
    {
    }

    public interface IExemploSingleton : IExemplo
    {
    }

    public interface IExemploSingletonInstance : IExemplo
    {
    }
}
