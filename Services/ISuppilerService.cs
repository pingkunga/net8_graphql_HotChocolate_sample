namespace GraphQLAPI.Services;

using GraphQLAPI.DTOs;

public interface ISupplierService
{
    Task<IEnumerable<SupplierDTO>> GetSuppliers();
    Task<SupplierDTO> GetSupplier(int id);
    Task<SupplierDTO> AddSupplier(SuppilerCreateDTO supplier);
    Task<SupplierDTO> UpdateSupplier(int id, SupplierDTO supplier);
    Task<bool> DeleteSupplier(int id);
}