# Language Integrated Query (LINQ) ##

- [Language Integrated Query (LINQ)](#language-integrated-query-linq)
  - [Wat is het](#wat-is-het)
  - [Voorbeelden](#voorbeelden)
  - [Extension Methods](#extension-methods)
    - [Oefeningen](#oefeningen)


## Wat is het ##

- Voegt query capaciteiten toe aan het .NET Framework.
- Zorgt er voor dat je met typed datasources kan werken (voor intellisense, compile time checking, ...).
- Kan je schrijven op elke datasource die `IEnumerable<T>` ondersteunt.
- Kan je op twee manieren schrijven: query syntax of method syntax, maakt functioneel niets uit.
- Verschillende providers voor verschillende functionaliteit: bv, de provider van EntityFramework vertaalt de LINQ query naar SQL.
- Pas op voor [Deferred Execution](https://medium.com/exam-70-487/deferred-execution-of-linq-query-39a925195b73).

## Voorbeelden ##

- Kan je terugvinden in [het voorbeeldproject](./IntroLinq)</a>

## Extension Methods ##

- Linq werkt aan de hand van "Extension Methods". Hiermee kan je extensies maken op classes die normaal "closed" zijn voor extension, zonder dat je een nieuwe klasse moet aanmaken.
- [Hier](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/extension-methods) kan je extra documentatie vinden.

### Oefeningen ###

- Maak een lijst aan van `Person`s (Name, Sex, DateOfBirth). Tien entiteiten zou genoeg moeten zijn. Zorg voor voldoende variatie.
- Filter nu op de personen ...
  - ... alle vrouwen
  - ... alle vrouwen wiens naam begint met een Z
  - ... alle personen die meerderjarig zijn
- Zorg ervoor dat je elke persoon kan printen in de lijsten en doe dit ook; je kan de `ToString` methode hier voor [overriden](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/how-to-override-the-tostring-method) 
