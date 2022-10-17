# InjecaoDependenciaExemplo

 Exemplo de Injeção de Dependencia com .net core 6 demonstrado em Meetup online
 
 Baseado na documentação [oficial da Microsoft](https://learn.microsoft.com/pt-br/dotnet/core/extensions/dependency-injection-usage?WT.mc_id=DOP-MVP-5003242)
 
 
* Transient objects : são sempre diferentes; uma nova instância é fornecida para cada controlador e cada serviço..

* Scoped objects: são iguais em uma solicitação, mas diferentes em solicitações diferentes.

* Singleton objects : são os mesmos para cada objeto e cada solicitação.

Ciclo de vida :

![Cilo de vida](https://github.com/TBertuzzi/InjecaoDependenciaExemplo/blob/main/Resources/LifeTime.jpg?raw=true)
