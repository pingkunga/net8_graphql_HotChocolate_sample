namespace GraphQLAPI.Services;

using AutoMapper;
using GraphQLAPI.DTOs;
using GraphQLAPI.Infra.Repositories;

public class SupplierService : ISupplierService
{
    private readonly ISupplierRepository _supplierRepository;
    private readonly IMapper _mapper;
    public SupplierService(ISupplierRepository supplierRepository, IMapper mapper)
    {
        _supplierRepository = supplierRepository;
        _mapper = mapper;
    }

    public async Task<IEnumerable<SupplierDTO>> GetSuppliers()
    {
        return await _supplierRepository.GetSuppliers();
    }

    public async Task<SupplierDTO> GetSupplier(int id)
    {
        return await _supplierRepository.GetSupplier(id);
    }

    public async Task<SupplierDTO> AddSupplier(SuppilerCreateDTO supplierCreate)
    {
        //map SuppilerCreateDTO to SupplierDTO
        SupplierDTO supplier = _mapper.Map<SupplierDTO>(supplierCreate);
        supplier = await _supplierRepository.AddSupplier(supplier);
        //return await _supplierRepository.AddSupplier(supplier);

        return supplier;
    }

    public async Task<SupplierDTO> UpdateSupplier(int id, SupplierDTO supplier)
    {
        return await _supplierRepository.UpdateSupplier(id, supplier);
    }

    public async Task<bool> DeleteSupplier(int id)
    {
        return await _supplierRepository.DeleteSupplier(id);
    }
}