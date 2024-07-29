using GraphQLAPI.Infra.Models;
using GraphQLAPI.Services;

namespace GraphQLAPI.GraphQL.Query
{
    public class SupplierGraphQLQuery
    {
        public async Task<IEnumerable<SupplierDTO>> GetAllSuppliers([Service]ISupplierService supplierService)
        {
            IEnumerable<SupplierDTO> suppliers = await supplierService.GetSuppliers();
            return suppliers;
        }

        public async Task<SupplierDTO> GetSupplierById([Service]ISupplierService supplierService, int id)
        {
            SupplierDTO supplier = await supplierService.GetSupplier(id);
            return supplier;
        }
    }
}