using GraphQLAPI.Infra.Models;

namespace GraphQLAPI.Infra.Repositories
{
    public interface ISupplierRepository
    {
        Task<IEnumerable<SupplierDTO>> GetSuppliers();
        Task<SupplierDTO> GetSupplier(int id);
        // Task<SupplierDTO> AddSupplier(Supplier supplier);
        // Task<SupplierDTO> UpdateSupplier(Supplier supplier);
        // Task<SupplierDTO> DeleteSupplier(int id);
    }

}