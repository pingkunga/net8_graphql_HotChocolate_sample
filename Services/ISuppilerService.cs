namespace GraphQLAPI.Services;

using GraphQLAPI.Infra.Models;

public interface ISupplierService
{
    Task<IEnumerable<SupplierDTO>> GetSuppliers();
    Task<SupplierDTO> GetSupplier(int id);
    // Task<SupplierDTO> AddSupplier(Supplier supplier);
    // Task<SupplierDTO> UpdateSupplier(Supplier supplier);
    // Task<SupplierDTO> DeleteSupplier(int id);
}