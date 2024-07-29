namespace GraphQLAPI.Services;

using GraphQLAPI.DTOs;

public interface ISupplierService
{
    Task<IEnumerable<SupplierDTO>> GetSuppliers();
    Task<SupplierDTO> GetSupplier(int id);
    Task<SupplierDTO> AddSupplier(SupplierDTO supplier);
}