# MyTeamCityProject

Навчальний проєкт для лабораторної роботи з налаштування CI/CD у TeamCity.

## Склад рішення

- `MyTeamCityProject` — консольний застосунок .NET 9, виводить `Hello, TeamCity!`
- `MyTeamCityProject.Tests` — модульні тести xUnit

## Збірка та запуск

```
dotnet build MyTeamCityProject.sln
dotnet test MyTeamCityProject.sln
dotnet run --project MyTeamCityProject
```

## CI

Збірка налаштована в TeamCity (конфігурація `Build`) і складається з двох кроків:

1. `dotnet build MyTeamCityProject.sln`
2. `dotnet test MyTeamCityProject.Tests/MyTeamCityProject.Tests.csproj`

Збірка запускається автоматично за тригером VCS Trigger при кожному коміті в гілку `main`.
