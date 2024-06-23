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