# ASP.NET MVC #

- [ASP.NET MVC](#aspnet-mvc)
  - [Aanmaken](#aanmaken)
  - [Structuur](#structuur)
    - [Folders](#folders)
  - [Routing](#routing)
  - [Razor syntax](#razor-syntax)
    - [Oefeningen](#oefeningen)

## Aanmaken ##

- Om een nieuwe asp.net mvc applicatie aan te maken: 
  - Voorzie een lege directory `mkdir MyAspMvc`
  - Navigeer naar deze directory 
  - Volgende commando `dotnet new mvc`
- Uitvoeren door `dotnet run`; bekijk zeker de output. Hierin staat een url, navigeer hierna.

## Structuur ##

- Je applicatie bestaat uit razorfiles (`*.cshtml`) en standaard c# files (`*.cs`).
- razorfiles zijn de (standaard) view van je applicatie.
- de controllers en de modellen zitten in `.cs` files

### Folders ###

| Folder / File | Dient voor ...             |
| ------------- | -------------------------- |
| Controller    | Controllers                |
| Models        | Models                     |
| Views         | Views                      |
| wwwroot       | Statische data             |
| Program.cs    | Maakt de webserver         |
| Startup.cs    | Configuratie en dergelijke |

## Routing ##

[Routing documentatie](https://docs.microsoft.com/en-us/aspnet/core/mvc/controllers/routing?view=aspnetcore-3.0)

## Razor syntax ##

Bekijk hiervoor de [documentatie van microsoft](https://docs.microsoft.com/en-us/aspnet/core/mvc/views/razor?view=aspnetcore-3.0).

### Oefeningen ###

1. Maak een nieuwe website aan.
2. Werk met een `ViewBag` ([tutorial](https://stackify.com/viewbag/)) om een lijst van items door te geven en deze te laten zien op het scherm. (Indien je geen inspiratie hebt: Person (id, firstName, lastName, dateOfBirth))
3. Doe hetzelfde met een model als argument parameter van de view.