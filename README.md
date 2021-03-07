# fs-address-book

Small sample project for playing around with F#. My intention with this project is to document all the steps I take and all the lessons I learn along the way.
https://fsharpforfunandprofit.com/posts/recipe-part2/

## Getting Started

In my first iteration of this project, I will start out with a simple console project. Starting from my root folder that right now only contains LICENSE and README.md I run

```
dotnet new console -lang "F#" -o App
dotnet new gitignore
dotnet new sln
dotnet sln add App/App.fsproj
```

Then run the project just to make sure everything works as expected

```
dotnet run -p App/App.fsproj
```

## Take Aways

- Data Centric Use Case
- Railway Oriented Programming
