# Entity Framework Core #

## Inhoud ##

- [Entity Framework Core](#entity-framework-core)
  - [Inhoud](#inhoud)
  - [Object Relational Mappers](#object-relational-mappers)
    - [Beschikbare ORMs](#beschikbare-orms)
  - [EF Core](#ef-core)
    - [Model](#model)
    - [DBSet](#dbset)
    - [DBContext](#dbcontext)
  - [Queries](#queries)
  - [Deferred Execution](#deferred-execution)
  - [Installatie ##](#installatie)
  - [Voorbeeld](#voorbeeld)

## Object Relational Mappers ##

De [wikipedia pagina](https://en.wikipedia.org/wiki/Object-relational_mapping) vat het goed samen:

> Object-relational mapping (ORM, O/RM, and O/R mapping tool) in computer science is a programming technique for converting data between incompatible type systems using object-oriented programming languages. This creates, in effect, a "virtual object database" that can be used from within the programming language. There are both free and commercial packages available that perform object-relational mapping, although some programmers opt to construct their own ORM tools. 

Samengevat:

* Er is een discrepantie tussen objecten (.NET) enerzijds en tabellen anderzijds.
* Risico op véél boilerplate code.
* Abstractie is hier nodig, enter ORM tools.

### Beschikbare ORMs ##

De meestegebruikte zijn ...

| Naam                                                 | Beschrijving                                                                    |
| ---------------------------------------------------- | ------------------------------------------------------------------------------- |
| [EF Core](https://docs.microsoft.com/en-us/ef/core/) | Microsoft supported                                                             |
| [Dapper](https://dapper-tutorial.net/dapper)         | Bijna zo snel als "raw queries"; ontwikkeld door de mensen achter stackexchange |
| [NHibernate](https://nhibernate.info/)               | Port van een java project; een van de eerste orms                               |


## EF Core ##

Met behulp van [EF Core](https://docs.microsoft.com/en-us/ef/core/) ga je je database op een eenvoudige wijze kunnen benaderen. De link bevat een algemene tutorial voor EF Core.

> Als je extra documentatie zoekt, zorg dat je zeker documentatie leest die gaat EF **Core**. Er is een groot verschil tussen EF Core en zijn voorganger (Entity Framework). Dit zal geen probleem zijn voor de grote concepten, maar zoals gewoonlijk zit "the devil in the details".

> Merk op: ik gebruik in mijn voorbeelden sqlite. Dit heeft als voordeel dat je je database snel kan wegsmijten (want het is file-based). De queries die gegenereerd worden kunnen afwijken mocht je kiezen voor een andere database. In weze maakt de keuze van je database niet uit.

### Model ###

Kan je zien als een 1:1 mapping van je tabel-row. Stel dat je bijvoorbeeld de volgende tabel hebt:

```sql
CREATE TABLE IF NOT EXISTS "Beers" (
    "Id" INTEGER NOT NULL CONSTRAINT "PK_Beers" PRIMARY KEY AUTOINCREMENT,
    "Name" TEXT NULL,
    "BeerTypeId" INTEGER NOT NULL,
    "BreweryId" INTEGER NOT NULL,
    CONSTRAINT "FK_Beers_BeerTypes_BeerTypeId" FOREIGN KEY ("BeerTypeId") REFERENCES "BeerTypes" ("Id") ON DELETE CASCADE,
    CONSTRAINT "FK_Beers_Breweries_BreweryId" FOREIGN KEY ("BreweryId") REFERENCES "Breweries" ("Id") ON DELETE CASCADE
);
CREATE INDEX "IX_Beers_BeerTypeId" ON "Beers" ("BeerTypeId");
CREATE INDEX "IX_Beers_BreweryId" ON "Beers" ("BreweryId");
```

Dan kan je dit mappen met

``` csharp
public class Beer : BaseDbClass
{
    public string Name { get; set; }
    public int BeerTypeId { get; set; }
    public BeerType BeerType { get; set; }
    public int BreweryId { get; set; }
}
```

Merk op: Id is niet aanwezig; deze zit in de `BaseClass`.

### DBSet ###

Een DBSet kan je zien als de "toegangsweg" naar je database; dit zijn `IQueryables` waarlangs je naar je feitelijke database gaat gaan.

### DBContext ###

Een DBContext is je database-object zelf; hierin definieer je je connection string. Deze gaat ook de connecties en dergelijke beheren. Je zet je `DbSet`s binnen je `DbContext`.

Een voorbeeld van een context en zijn sets kan je [hier](https://github.com/rceuls/Course2019/blob/Brewery_EFCore/BreweryFull/Brewery.Shared/BeerContext.cs) vinden.

## Queries ##

Queries gebeuren door middel van LINQ.

```csharp
var data = _breweryContext.Breweries.FirstOrDefault(x => x.Id == id)
```

Achterliggend vertaalt EF dit naar

```sql
SELECT "b"."Id", "b"."Name", "b"."OwnerId"
FROM "Breweries" AS "b"
```

## Deferred Execution ##

Lees hiervoor de volgende link na: <https://docs.microsoft.com/en-us/dotnet/framework/data/adonet/ef/language-reference/query-execution>

## Installatie ## 

Je kan best via [deze pagina](https://docs.microsoft.com/en-us/ef/core/providers/?tabs=dotnet-core-cli) opzoeken welke database provider je nodig hebt. Deze kan je dan installeren door, bijvoorbeeld, 
`dotnet add package Microsoft.EntityFrameworkCore.Sqlite` (voor <https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.Sqlite> (".NET CLI" tab)) in te voeren in je console bij je project waarin je de referentie wilt toevoegen. Dit werkt analoog met npm. 

## Voorbeeld ##

Je kan voorbeelden vinden van hoe je je project aanpast voor EF Core op de [pull request van brewery](https://github.com/rceuls/Course2019/pull/1/files). Deze omvat het verschil tussen de statische aanpak die we tot nu toe hanteerden en de database aanpak die we vanaf nu gaan toepassen. Let vooral op de volgende bestanden en aanpassingen:

* Merk op dat nu overal netstandard2.**1** staat ipv netstandard2.**0**. Dit is belangrijk, anders kan je EF Core niet installeren (want deze verwacht een library met netstandard2.1). Mocht je nog niet op .NET Core 3.X zitten, zal je hiervoor moeten switchen.
* `Startup.cs` gaat er voor zorgen dat je de database kan inladen en dat die beschikbaar is, application wide. Let vooral op de veranderingen aan `ConfigureServices` (waar je je context gaat registeren) en `Configure` (waar je je database gaat opvullen).
* `appsettings.json` bevat de connectionstring. Deze is specifiek voor sqlite, raadpleeg de documentatie voor de connectionstring van jouw provider mocht je een andere gebruiken.
* `Brewery.Shared` omvat nu ook de database implementatie; het staat je vrij om deze in een aparte library te zetten.
* `DatabaseInitializer.cs` bevat een initialisatie van de database. Let er op dat je eerst een `EnsureCreated` methode aanroept op de context. Deze is belangrijk (en handig) want deze maakt automatisch je database aan indien ze nog niet bestaat. **Mocht je database wijzigingen hebben omdat je model anders is kan je ofwel migraties toepassen (buiten de scope van deze cursus) ofwel je database opnieuw laten aanmaken**.
