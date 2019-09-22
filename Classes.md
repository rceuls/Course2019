# C# - Object-Oriented Programming #

## Inhoud ##
- [C# - Object-Oriented Programming](#c---object-oriented-programming)
  - [Inhoud](#inhoud)
  - [Classes](#classes)
    - [Oefeningen](#oefeningen)
  - [Interfaces](#interfaces)
    - [Oefeningen](#oefeningen-1)
  - [OO Principes](#oo-principes)
    - [Abstraction](#abstraction)
    - [Encapsulation](#encapsulation)
    - [Inheritance](#inheritance)
    - [Polymorphism](#polymorphism)

## Classes ##

- Een class bestaat uit _attributes_ en _behaviour_. Attributes zijn "velden" waarin je data bewaart. Bij een auto is dit bijvoorbeeld de kleur, model, ... . Behaviour zijn acties die het object kan ondernemen: _start_, _stop_, ... .
- Een object is een instantie van de een class. Je vader zijn Volvo is een instantie van een auto-class.

```cs --source-file ./OOCsharp/Basic.cs --region OO1 --project ./OOCsharp/OOCsharp.csproj
```

### Oefeningen ##

- Maak een nieuw project aan.
- Modelleer hierin een dierenasiel voor katten en honden.

## Interfaces ##

- Contracten die je oplegt aan je classes.
- Kan je lezen als een "is-a" definitie. "A car **is a** Vehicle".
- By convention starten met een I (IVehicle).

```cs --source-file ./OOCsharp/Interfaces.cs --region OO2 --project ./OOCsharp/OOCsharp.csproj
```


### Oefeningen ###

- Bedenk een paar logische interfaces voor de classes uit de eerste oefening.

## OO Principes ##

### Abstraction ###

- Zorgt ervoor dat je weet _wat_ een module doet, zonder dat je moet weten _hoe_.

### Encapsulation ###

- Sluit aan bij abstractie.
- "Verstopt" de complexiteit van een object zodat de end-user alleen maar te zien krijgt wat er precies moet getoond worden.

### Inheritance ###

- Zie het hoofdstuk over interfaces.
- Kan je ook doen met een klasse-hierarchie.

### Polymorphism ###
