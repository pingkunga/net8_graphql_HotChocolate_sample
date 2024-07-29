using GraphQLAPI.DTOs;
using GraphQLAPI.Services;

namespace GraphQLAPI.GraphQL.Mutation
{
    public class SupplierGraphQLMutation
    {
        public async Task<SupplierDTO> AddSupplier([Service] ISupplierService supplierService, SupplierDTO newSupplier)
        {
            return await supplierService.AddSupplier(newSupplier);
        }
    }
}