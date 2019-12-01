# Unit testing

- [Unit testing](#unit-testing)
  - [Frameworks](#frameworks)
  - [Dependency injection](#dependency-injection)

## Frameworks

- Verschillende frameworks.
- Geen substantieel verschil.
- Voor uniformiteit gebruiken wij nunit; deze is op de meeste CI environments supported.
- Best in een apart project; unit testen zijn een development tool en dien je niet mee op te leveren in het finale artifact van je applicatie.

## Dependency injection

- Zo atomair mogelijk. 
- In plaats van elke keer "alles" door te sturen ga je een deel mocken. Als je , bijvoorbeeld, je business logica wenst af te testen kan je dit perfect doen zonder database calls. Dan kan je je database perfect mocken.
- Hiervoor zijn ook libraries die je kan gebruiken; een van de meestgebruikte is (Moq)[https://www.nuget.org/packages/Moq/].
- Je maakt "valse" objecten en checkt de interactie met de objecten in kwestie; je wilt bv niet afchecken _of_ je saved maar wel of je `IDataAccess` aanroept met bepaalde parameters.

