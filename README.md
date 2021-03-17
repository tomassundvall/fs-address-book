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

## About the Address Book Application

## Resources

[Docs match expression](<https://docs.microsoft.com/en-us/previous-versions/visualstudio/visual-studio-2012/dd233242(v=vs.110))
[More on match expression](https://fsharpforfunandprofit.com/posts/match-expression/)
[Docs pattern matching](<https://docs.microsoft.com/en-us/previous-versions/visualstudio/visual-studio-2012/dd547125(v=vs.110)>)

## Take Aways

- Data Centric Use Case
- Railway Oriented Programming
