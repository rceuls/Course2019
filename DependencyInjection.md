# Dependency Injection

- [Dependency Injection](#dependency-injection)
  - [Wat en Waarom](#wat-en-waarom)
  - [Binnen ASP.NET](#binnen-aspnet)
  - [In de praktijk](#in-de-praktijk)
    - [Implementatie](#implementatie)

## Wat en Waarom

Dependency injection is een begrip dat de [modularity](https://en.wikipedia.org/wiki/Modular_programming) van je applicatie in de hand werkt. Een goed geschreven programma is opgesplits in verschillende onderdelen die elk hun eigen verantwoordelijk hebben. Op deze manier kan je makkelijk modules vervangen. Aparte modules zijn ook makkelijker om apart te testen.

## Binnen ASP.NET

Dependency injection is standaard [ondersteund](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/dependency-injection?view=aspnetcore-3.0) binnen ASP.NET. **Deze link is belangrijk, neem hem zeker door**. Verdere theoretische uitleg kan je [hier](https://docs.microsoft.com/en-us/dotnet/architecture/modern-web-apps-azure/architectural-principles#dependency-inversion) vinden. Deze link gaat specifiek over azure applicaties maar deze principes zijn overal toepasbaar.

## In de praktijk

Je kan het best de verschillende "areas" van je applicatie opsplitsen in aparte classes; het is bijvoorbeeld handiger om je database implementatie apart te zetten van de rest van je applicatie. Mocht je dan kiezen om tijdens je project dan om te schakelen naar een andere "datalayer" (ipv EF wil je bijvoorbeeld Dapper gebruiken) moet je alleen deze module updaten.

### Implementatie

Een voorbeeld kan je zien op op deze [commit](https://github.com/rceuls/Course2019/commit/7bd07c0584b7b3569597688a3acc4388a224cc1b)
