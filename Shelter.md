# Opdracht #

- [Opdracht](#opdracht)
  - [Aanmaken projectstructuur](#aanmaken-projectstructuur)
  - [Domainmodel](#domainmodel)
  - [ASP.NET MVC - basis](#aspnet-mvc---basis)
  - [ASP.NET MVC - detail screen](#aspnet-mvc---detail-screen)
  - [ASP.NET MVC - JSON Endpoints](#aspnet-mvc---json-endpoints)

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

## ASP.NET MVC - detail screen ##

- Zorg ervoor dat je, als je op de naam van het dier klikt, naar een detailpagina gaat waar je de details van het dier kan bekijken.
  - Waarschijnlijk ga je hiervoor een `id` moeten toevoegen aan de `Animal` class
  - Lees ook eens na hoe [tag helpers](https://docs.microsoft.com/en-us/aspnet/core/mvc/views/tag-helpers/built-in/anchor-tag-helper?view=aspnetcore-3.0) werken.

- Zorg ervoor dat er een delete knop (of link, of ...) naast het dier staat (op de overzichtslijst) waardoor je naar een confirmation page gaat. Op deze pagina staan twee knoppen (confirm, back). Deze gaan ofwel terugnavigeren naar de overzichtspagina, ofwel eerst deleten en dan terug navigeren naar de overzichtspagina.

- Zorg ervoor dat je delete een POST doet (via een form) die het dier in kwestie gaat verwijderen; navigeer daarna terug naar de hoofdpagina.

- Maak een editform waarin je de _naam_ van het dier kan aanpassen; de rest moet (voorlopig) niet. Dezelfde behaviour als bij de delete: update het item en navigeer terug naar het overzichtscherm.

## ASP.NET MVC - JSON Endpoints ##

- Voorzie een extra controller (`/api`) met daarop een aantal subroutes
  - `/api/brewery/` geeft een lijst van terug van { id, name } van de shelter
  - `/api/brewery/<id>/beers` geeft een lijst van alle dieren van die shelter weer

Alle resultaten moeten in `json` teruggegeven worden. [Deze link](https://docs.microsoft.com/en-us/aspnet/core/web-api/?view=aspnetcore-3.0) is een goed startpunt hiervoor.
