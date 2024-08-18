using GraphQLAPI.DTOs;

namespace GraphQLAPI.Infra.Repositories
{
    public interface ISupplierRepository
    {
        Task<IEnumerable<SupplierDTO>> GetSuppliers();
        Task<SupplierDTO> GetSupplier(int id);
        Task<SupplierDTO> AddSupplier(SupplierDTO supplier);
        Task<SupplierDTO> UpdateSupplier(int Id, SupplierDTO supplier);
        Task<bool> DeleteSupplier(int id);
    }

}