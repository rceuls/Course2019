# Language Integrated Query (LINQ) ##

## Wat is het ##

* Voegt query capaciteiten toe aan het .NET Framework.
* Zorgt er voor dat je met typed datasources kan werken (voor intellisense, compile time checking, ...).
* Kan je schrijven op elke datasource die IEnumerable<T> ondersteunt.
* Kan je op twee manieren schrijven: query syntax of method syntax, maakt functioneel niets uit.
* Verschillende providers voor verschillende functionaliteit: bv, de provider van EntityFramework vertaalt de LINQ query naar SQL.

## Voorbeelden ##

* Kan je terugvinden in [het voorbeeldproject](./IntroLinq)</a>

## Extension Methods ##

* Linq werkt aan de hand van "Extension Methods". Hiermee kan je extensies maken op classes die normaal "closed" zijn voor extension, zonder dat je een nieuwe klasse moet aanmaken.
* [Hier](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/extension-methods) kan je extra documentatie vinden.
