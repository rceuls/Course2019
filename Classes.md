# C# - Object-Oriented Programming #

## Inhoud ##
- [C# - Object-Oriented Programming](#c---object-oriented-programming)
  - [Inhoud](#inhoud)
  - [Classes](#classes)
    - [Oefeningen](#oefeningen)
  - [Interfaces/Abstract classes](#interfacesabstract-classes)
    - [Oefeningen](#oefeningen-1)
  - [OO Principes](#oo-principes)
    - [Abstraction](#abstraction)
    - [Encapsulation](#encapsulation)
    - [Inheritance](#inheritance)
    - [Polymorphism](#polymorphism)
  - [Bringing it all together](#bringing-it-all-together)
  - [Bringing it all together - Part II](#bringing-it-all-together---part-ii)

## Classes ##

- Een class bestaat uit _attributes_ en _behaviour_. Attributes zijn "velden" waarin je data bewaart. Bij een auto is dit bijvoorbeeld de kleur, model, ... . Behaviour zijn acties die het object kan ondernemen: _start_, _stop_, ... .
- Een object is een instantie van de een class. Je vader zijn Volvo is een instantie van een auto-class.

```cs --source-file ./OOCsharp/Basic.cs --region OO1 --project ./OOCsharp/OOCsharp.csproj
```

### Oefeningen ##

- Maak een nieuw project aan.
- Modelleer hierin een dierenasiel voor katten en honden.

## Interfaces/Abstract classes ##

- Contracten die je oplegt aan je classes.
- Een interface kan je lezen als een "can-do" definitie. "A Car **can do** IVehicle stuff". Starten by convention met een hoofdletter I.
- Je hebt ook abstracte classes, die meer een "is-a" definitie omvatten. "A Car **is a** Vehicle".  
- Een class kan meerdere interfaces implementeren, maar maar één abstracte class.

```cs --source-file ./OOCsharp/Interfaces.cs --region OO2 --project ./OOCsharp/OOCsharp.csproj
```

### Oefeningen ###

- Bedenk een paar logische interfaces voor de classes uit de eerste oefening.

## OO Principes ##

### Abstraction ###

- Zorgt ervoor dat je weet _wat_ een module doet, zonder dat je moet weten _hoe_.
- Als je methodes wil implementeren moet je [overrides](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/override) gebruiken in de classes die overerven van een base-class.
- Alle methodes die je wilt kunnen overriden moeten [abstract](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/abstract) _of_ [virtual](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/virtual) zijn. Abstracte methodes moét je overriden (anders compiler fout). Virtuele methodes kan je overriden. Niet-virtual methodes kan je niet overriden maar kan je re-implementeren met het [new keyword](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/new-modifier) (bad practice).

```cs --source-file ./OOCsharp/AbstractClasses.cs --region OO3 --project ./OOCsharp/OOCsharp.csproj
```

### Encapsulation ###

- Sluit aan bij abstractie.
- "Verstopt" de complexiteit van een object zodat de end-user alleen maar te zien krijgt wat er precies moet getoond worden.
- Kan je doen met behulp van [access modifiers](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/access-modifiers). Je kan je (zeker initieel) het beste beperken tot public, protected en private.

### Inheritance ###

- Zie het hoofdstuk over interfaces.
- Kan je ook doen met een klasse-hierarchie.

### Polymorphism ###

```cs --source-file ./OOCsharp/Polymorphism.cs --region OO4 --project ./OOCsharp/OOCsharp.csproj
```

## Bringing it all together ##

TL;DR Herwerk de oefening uit de vorige les op een OO manier.

- Gebruikers in een database.
- Voorzie de mogelijkheid om onderscheid te maken tussen "Administrators" en "Users".
- Voorzie CRUD-methodes.
- Zorg ervoor dat een user op zijn minst een naam, voornaam en leeftijd heeft. Deze moeten uniek zijn binnen het systeem. Als je een gebruiker toevoegt die al bestaat geef je een fout (zonder het programma af te sluiten).
- Als je het werkende krijgt met een lijst, doe dan hetzelfde met een [Hashset](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.hashset-1?view=netcore-2.2). Zoek hiervoor op hoe GetHashCode(), Equals(), ... werkt. Bekijk hiervoor zeker [HashCode](https://docs.microsoft.com/en-us/dotnet/api/system.hashcode?view=netstandard-2.1).

## Bringing it all together - Part II ##

- Modelleer een brouwerij: een brouwerij heeft een eigenaar en een lijst van bieren (naam, type). Een bier heeft een bepaald type (naam).
- Vul de brouwerij op; interactief moet niet.
- Schrijf een console-applicatie dit uitprint op de STDOUT.
- Probeer zeker het volgende scenario uit: print alle bieren uit, verander de naam van één van de types. Print terug alle bieren uit.

> Lees het volgende na om te weten _waarom_ dit zo is: [Value types](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/value-types) en [Reference types](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/reference-types).
