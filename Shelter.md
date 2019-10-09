# Opdracht #

- [Opdracht](#opdracht)
  - [Aanmaken projectstructuur](#aanmaken-projectstructuur)
  - [Domainmodel](#domainmodel)
  - [ASP.NET MVC - basis](#aspnet-mvc---basis)

We gaan een aanzet geven voor de "grote oefening".

## Aanmaken projectstructuur ##

- `mkdir Shelter`, bv `Shelter`
- Navigeer naar die subdirectory
- Maak een nieuw project aan: `dotnet new console -o Shelter.Shared`
- Open deze folder in je editor.

Dit project gaat dienen voor onze "gedeelde" code. Maak hierin een folder aan voor het domeinmodel. Je namespace gaat `Shelter.Shared.Domain` zijn.

## Domainmodel ##

> Hou rekening met de namespace! Je kan dit model voorlopig testen door de `Program.cs` wat objecten te laten aanmaken; later gaan we deze integreren via ASP.NET.

- Een dierenasiel (`Shelter`) heeft een lijst van dieren (`Animals`).
- Een dierenasiel heeft medewerkers (`Employees`).
- Het systeem kent de volgende rollen/medewerkers: `Manager`, `Caretaker`, `Administrator`.
- Elke medewerker met de rol `Caretaker` staat in voor één of meedere dieren.
- Een dier kan ofwel een `Dog`, `Cat` of `Other` zijn.
  - Alle dieren hebben een `Name`, `DateOfBirth`, `IsChecked`, `KidFriendly` en `Since` (datetime)
  - Een kat heeft `Race`, `Declawed`.
  - Een hond heeft `Race`, `Barker`
  - Andere heeft `Description`, `Kind`

## ASP.NET MVC - basis ##

- Maak een nieuw MVC project
- Voeg een referentie toe aan dat MVC project naar je "Shared" library via `dotnet add` ([documentatie](https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-add-reference))
- Maak een nieuwe controller aan (`ShelterController`)
- Zorg dat deze een index page heeft met daarop een (hardcoded) lijst van dieren. Gebruik hiervoor dezelfde modellen als in je Shared library.
- Gebruik géén `ViewData`; zorg voor een model.