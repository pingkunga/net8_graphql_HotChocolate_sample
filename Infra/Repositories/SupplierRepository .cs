namespace GraphQLAPI.Infra.Repositories;

using GraphQLAPI.Infra.Models;
using System.Collections.Generic;

public class SupplierRepository: ISupplierRepository
{
    private readonly IEnumerable <SupplierDTO> suppliers = new List <SupplierDTO>
    {
        new SupplierDTO
        {
            Id = 1,
            FirstName = "PingkungA",
            LastName = "Agnukginp",
            Address = "Thailand, BKK",
            Phone = "082-123-4569",
            Email = "pingkunga@debuggingsoft.com"
        },
        new SupplierDTO
        {
            Id = 2,
            FirstName = "Faii",
            LastName = "Foster",
            Address = "Thailand, Chiangrai",
            Phone = "082-123-4561",
            Email = "abc@Foster.com"
        },
        new SupplierDTO
        {
            Id = 3,
            FirstName = "Steve",
            LastName = "Chan",
            Address = "HK, Kowloon",
            Phone = "9999999999",
            Email = "xyz@abc.com"
        }
    };

    public async Task <IEnumerable <SupplierDTO>> GetSuppliers()
    {
        return await 
        Task.FromResult(suppliers);
    }

    public async Task <SupplierDTO> GetSupplier(int Id)
    {
        return await Task.FromResult(suppliers.FirstOrDefault(x => x.Id == Id));
    }
  }
