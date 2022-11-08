# Dotnet Core Scaffold With PostgreSQL

This project use .NET 6 LTS

When you created new projects success. You need to add package to manage database postgresql

- Install ef tool
```sh
dotnet tool install --global dotnet-ef
```

- Add Ngsql
```sh
dotnet add package Npgsql.EntityFrameworkCore.PostgreSQL --version 6.0.7
```

- Add Entity Core Design
```sh
dotnet add package Microsoft.EntityFrameworkCore.Design --version 6.0.7
```

*** Run this command after you add model to DBContext finished
```sh
dotnet ef migrations add InitialCreate
```
and
```sh
dotnet ef database update
```

*** Use this command if you have exited database
```sh
dotnet ef dbcontext scaffold \
    "Host=localhost;Port=5432;Database=test;Username=postgres;Password=password" \
    Npgsql.EntityFrameworkCore.PostgreSQL
```
Or with specify namespace
```sh
dotnet ef dbcontext scaffold "Host=localhost;Port=5432;Database=test;Username=postgres;Password=password" \
    Npgsql.EntityFrameworkCore.PostgreSQL \
    --context TestDbContext \
    --context-namespace ScaffoldPostgresql.PostgreSQL \
    --context-dir PostgreSQL \
    --namespace ScaffoldPostgresql.Models \
    --output-dir Models \
    --force
```

## Reference
- [First App with .NET Core CLI](https://learn.microsoft.com/en-us/ef/core/get-started/overview/first-app?tabs=netcore-cli)
- [Getting Started - Npgsql Entity Framework Core Provider](https://www.npgsql.org/efcore/index.html)