# README #

To run this repo you need both the .NET Core SDK [3.X](https://dotnet.microsoft.com/download/dotnet-core/3.0) and the [.NET try](https://github.com/dotnet/try) tool. Check out this repo, install the tool and run `dotnet try` in the root. Click on the link at the bottom of this page on your local machine.

## FAQ ##

### My command prompt says "no dotnet-try" found? ###

- Make sure the dotnet tools directory is added to your PATH. On windows this is at %USERPROFILE%/.dotnet/tools. Unix systems use ~/.dotnet/tools. Refresh your path afterwards.

### The samples don't seem to run ###

- If this happens ...
  1. Cancel the process with ctrl+c
  2. navigate into the "IntroCsharp" directory
  3. run `dotnet.build`
  4. navigate back to the parent folder and try `dotnet try` again.

## Course ##

- <a href="Intro.md"> Intro</a>
- <a href="Classes.md"> Object Oriented Programming</a>
- <a href="Linq.md"> Linq</a>
- <a href="ASPNET_intro.md">Intro ASP.NET</a>

## Assignment ##

- <a href="Shelter.md">Part 1</a>