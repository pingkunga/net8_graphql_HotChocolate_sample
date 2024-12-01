using GraphQLAPI.DTOs;
using GraphQLAPI.Services;

namespace GraphQLAPI.GraphQL.Mutation
{
    public class SupplierGraphQLMutation
    {
        public async Task<SupplierDTO> AddSupplier([Service] ISupplierService supplierService, SuppilerCreateDTO newSupplier)
        {
            try
            {
                return await supplierService.AddSupplier(newSupplier);
            }
            catch (Exception ex)
            {
                throw new GraphQLException(new ErrorBuilder()
                    .SetMessage(ex.Message)
                    .SetCode("SUPPLIER_ADD_ERROR")
                    .Build());
            }
        }

        public async Task<SupplierDTO> UpdateSupplier([Service] ISupplierService supplierService, int id, SupplierDTO supplier)
        {
            //return await supplierService.UpdateSupplier(id, supplier);
            try
            {
                return await supplierService.UpdateSupplier(id, supplier);
            }
            catch (Exception ex)
            {
                throw new GraphQLException(new ErrorBuilder()
                    .SetMessage(ex.Message)
                    .SetCode("SUPPLIER_UPDATE_ERROR")
                    .Build());
            }
        }

        public async Task<bool> DeleteSupplier([Service] ISupplierService supplierService, int id)
        {
            try
            {
                return await supplierService.DeleteSupplier(id);
            }
            catch (Exception ex)
            {
                throw new GraphQLException(new ErrorBuilder()
                    .SetMessage(ex.Message)
                    .SetCode("SUPPLIER_DELETE_ERROR")
                    .Build());
            }
        }
    }
}