namespace GraphQLAPI.Services;

using GraphQLAPI.Infra.Models;

public interface ISupplierService
{
    Task<IEnumerable<SupplierDTO>> GetSuppliers();
    Task<SupplierDTO> GetSupplier(int id);
    Task<SupplierDTO> AddSupplier(SupplierDTO supplier);
}