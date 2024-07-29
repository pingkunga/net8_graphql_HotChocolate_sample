dotnet new webapi --use-controllers -o GraphQLAPI

dotnet add package HotChocolate.AspNetCore
dotnet add package HotChocolate.AspNetCore.Playground


query {
    allSuppliers{
        id
        firstName
        lastName
    }
}

query {
  supplierById(id:1){
    firstName
    address
    phone
  }
}

# TiDB + MySQL Connector

* package

```
dotnet add package Microsoft.EntityFrameworkCore
dotnet add package Microsoft.EntityFrameworkCore.Tools
dotnet add package Pomelo.EntityFrameworkCore.MySql

Note: 
MySql.EntityFrameworkCore
//Ref: https://dev.mysql.com/doc/connector-net/en/connector-net-entityframework-core-example.html
```

* Schema 

- Add field or Entity Run 

```
dotnet ef migrations add intial 
```

- List
```
List out pending migrations
dotnet ef migrations list --project .\GraphQLAPI.csproj

Update database with pending migrations
dotnet ef database update --project .\GraphQLAPI.csproj
```

# Automapper

```
dotnet add package AutoMapper.Extensions.Microsoft.DependencyInjection
```
