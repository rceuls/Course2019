# C# - fundamenten #

## Inhoud ##

- [C# - fundamenten](#c---fundamenten)
  - [Inhoud](#inhoud)
  - [Hello world](#hello-world)
    - [Oefeningen](#oefeningen)
  - [Variabelen en datatypes](#variabelen-en-datatypes)
    - [Oefeningen](#oefeningen-1)
  - [Conditionals](#conditionals)
    - [Oefeningen](#oefeningen-2)
  - [Collecties](#collecties)
    - [Arrays](#arrays)
    - [Lists](#lists)
    - [Anderen](#anderen)
    - [Oefeningen](#oefeningen-3)
  - [Iteraties](#iteraties)
    - [Foreach](#foreach)
    - [Do while/while do](#do-whilewhile-do)
    - [Oefeningen](#oefeningen-4)
  - [Bringing it all together](#bringing-it-all-together)

## Hello world ##

```cs --source-file ./IntroCsharp/HelloWorld.cs --region HelloWorld --project ./IntroCsharp/IntroCsharp.csproj
```

Hoe bekom je dit programma:

1. Zorg ervoor dat je de dotnet core SDK geïnstalleerd hebt staan.
2. Open een terminal (cmd, powershell, bash, ...) en ga naar je projectfolder (on ons voorbeeld '~/dev' -- `cd dev`).
3. Voer het volgende commando uit: `dotnet new console -o ./HelloWorld` en nevigeer naar de juist aangemaakte subfolder (`cd HelloWorld`).
4. Om het programma uit te voeren kan je `dotnet run` doen. Dit compileert alle bestanden en runned het hoofdprogramma (by convention de `Main` methode in `Program.cs`).
5. De code bekijken kan uiteraard ook; open de folder in je favoriete editor/IDE. De `.cs` bestanden zijn hier het belangrijkste.

### Oefeningen ###

- Verwijder de System. van de System.Console lijn; welke fout krijg je?
- Bekijk hoe [de using directive](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/using-directive) werkt, lost het bovenstaande probleem op.

## Variabelen en datatypes ##

```cs --source-file ./IntroCsharp/Variables.cs --region VariableUsage --project ./IntroCsharp/IntroCsharp.csproj
```

Je kan op twee manieren een variable declareren: met `var` of met de volledige typenaam (`string` in ons voorbeeld). Als je `var` gebruikt gaat het systeem tijdens de compilatiestap dit proberen af te leiden uit de context; indien dit niet kan krijg je een fout. Verschillende soorten datatypes kan je terugvinden op [MSDN](https://docs.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/types-and-variables).

### Oefeningen ###

- Probeer van twee variabelen de som te maken en te printen naar STDOUT.
- Probeer een string en een int op te tellen; welke fout krijg je?
- Zoek de verschillende manieren van string interpolation op en probeer ze uit; welke ligt het beste?
- Zorg er voor dat je zeker de volgende datatypes snapt en kan gebruiken: boolean, string, int, double.

## Conditionals ##

```cs --source-file ./IntroCsharp/Conditionals.cs --region ConditionalIf --project ./IntroCsharp/IntroCsharp.csproj
```

Dit is een hopeloos verbose manier om een `if` te schrijven.

```cs --source-file ./IntroCsharp/Conditionals.cs --region ConditionalOr --project ./IntroCsharp/IntroCsharp.csproj
```

Dit is al korter en doet exact hetzelfde. `||` geeft aan dat je een `conditional or` hier wilt doen.

```cs --source-file ./IntroCsharp/Conditionals.cs --region ConditionalSwitch --project ./IntroCsharp/IntroCsharp.csproj
```

En je kan ook een switch gebruiken; dit doet wederom juist hetzelfde. Let op het volgende: de positie van het break statement, de waarden die je opvult en het default statement op het einde.

### Oefeningen ###

- Verwijder de break statements en kijk wat het resultaat is.
- Het `switch` statement kan korter, probeer de kortst mogelijke manier te vinden.
- Schrijf een stukje code met de volgende functionaliteit: als vandaag een weekdag is én het is voor vier uur 's namiddags print je "a", anders print je "b".
  - Hoe test je dit?
  - "Vandaag" moet je niet hardcoderen, hier bestaat een methode voor.

## Collecties ##

### Arrays ###

```cs --source-file ./IntroCsharp/Collections.cs --region CollectionsArray --project ./IntroCsharp/IntroCsharp.csproj
```

Een array ...

- heeft een vastgestelde lengte
- alle objecten hebben hun default waarde (null voor de meeste, 0 voor integers, ... )
- zero indexed
- één type / array. Allemaal string, allemaal int, niet door elkaar.

Vragen

- Hoe kan je één item displayen van de array?
- Kan je een array item ophalen ook al heb je er niet expliciet een waarde aan toegekend?
- Kan je array's resizen? Hoe?

### Lists ###

```cs --source-file ./IntroCsharp/Collections.cs --region CollectionsList --project ./IntroCsharp/IntroCsharp.csproj
```

Een list ...

- heeft géén vastgestelde lengte
- geen default waarden.
- zero indexed
- één type / list. Allemaal string, allemaal int, niet door elkaar.
- Hetgene tussen de haken noemt een "generic" en geeft een aanduiding van welk type de list-elements zijn.

Vragen

- Hoe haal je een bepaald item op vanop een bepaalde plaats in een list?

### Anderen ###

Andere collecties die belangrijk zijn:

- [Dictionary](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2?view=netcore-2.2)
- [Queue](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.queue-1?view=netcore-2.2)

### Oefeningen ###

- Maak een dictionary met als key de dagen van de week (gebruik hiervoor de `DayOfWeek` enumeratie) en als value de aantal uren les dat je hebt.
- Toon deze dan volgens het formaat "WEEKDAG - uren les: AANTAL" op STDOUT.

## Iteraties ##

### Foreach ###

```cs --source-file ./IntroCsharp/Iterators.cs --region IteratorsForeach --project ./IntroCsharp/IntroCsharp.csproj
```

### Do while/while do ###

```cs --source-file ./IntroCsharp/Iterators.cs --region IteratorsDoWhile --project ./IntroCsharp/IntroCsharp.csproj
```

### Oefeningen ###

- Zoek uit hoe een standaard `for` werkt en maak het voorbeeld van de foreach met een standaard for.

## Bringing it all together ##

Een grotere oefening ditmaal; je kan hiervoor best een echt apart project aanmaken.

- We gaan een in-memory database maken die je manipuleert via de commandline.
- We gaan van een lijst van personen de leeftijd bijhouden; welk datatype gebruik je best om de collectie voor te stellen?
- Zorg ervoor dat je een oneindige loop krijgt met behulp van Console.ReadLine() en ondersteun de volgende commandos:
  - exit
  - add <naam> <leeftijd>
  - update <naam> <leeftijd>
  - remove <naam>
  - list (laat alles zien)
- Zorg ervoor dat je alleen positieve nummers kan invoeren voor de leeftijd. Als je een update doet mag je géén lagere leeftijd toekennen.

Je gaat het volgende (zeker, minstens) nodig hebben:

- <https://docs.microsoft.com/en-us/dotnet/api/system.console.readline?view=netcore-2.2>
- <https://docs.microsoft.com/en-us/dotnet/api/system.int32.parse?view=netcore-2.2>
