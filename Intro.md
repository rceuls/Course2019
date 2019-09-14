# C# - fundamenten #

## Inhoud ##

- [C# - fundamenten](#c---fundamenten)
  - [Inhoud](#inhoud)
  - [Hello world](#hello-world)
    - [Oefeningen](#oefeningen)
  - [Variabelen en datatypes](#variabelen-en-datatypes)
    - [Oefeningen](#oefeningen-1)

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

- Verwijder links en rechts wat code; bekijk het effect.

## Variabelen en datatypes ##

```cs --source-file ./IntroCsharp/Variables.cs --region VariableUsage --project ./IntroCsharp/IntroCsharp.csproj
```

Je kan op twee manieren een variable declareren: met `var` of met de volledige typenaam (`string` in ons voorbeeld). Als je `var` gebruikt gaat het systeem tijdens de compilatiestap dit proberen af te leiden uit de context; indien dit niet kan krijg je een fout. Verschillende soorten datatypes kan je terugvinden op [MSDN](https://docs.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/types-and-variables).

### Oefeningen ###

- Probeer van twee variabelen de som te maken en te printen naar STDOUT.
- Probeer een string en een int op te tellen; welke fout krijg je?
- Zoek de verschillende manieren van string interpolation op en probeer ze uit; welke ligt het beste?
