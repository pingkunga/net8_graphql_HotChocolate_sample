namespace GraphQLAPI.Services;

using GraphQLAPI.Infra.Models;
using GraphQLAPI.Infra.Repositories;

public class SupplierService : ISupplierService
{
    private readonly ISupplierRepository _supplierRepository;

    public SupplierService(ISupplierRepository supplierRepository)
    {
        _supplierRepository = supplierRepository;
    }

    public async Task<IEnumerable<SupplierDTO>> GetSuppliers()
    {
        return await _supplierRepository.GetSuppliers();
    }

    public async Task<SupplierDTO> GetSupplier(int id)
    {
            return await _supplierRepository.GetSupplier(id);
    }
}