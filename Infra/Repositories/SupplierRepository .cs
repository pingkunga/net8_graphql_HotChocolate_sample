namespace GraphQLAPI.Infra.Repositories;

using AutoMapper;
using GraphQLAPI.DTOs;
using GraphQLAPI.Infra.Models;
using System.Collections.Generic;

public class SupplierRepository: ISupplierRepository
{
    
    private readonly DataDBContext _context;
    private readonly IMapper _mapper;

    public SupplierRepository(DataDBContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task <IEnumerable <SupplierDTO>> GetSuppliers()
    {
        IList<SupplierModel> supplierModels = _context.Suppliers.ToList();

        return await Task.FromResult(_mapper.Map<IEnumerable<SupplierDTO>>(supplierModels));
    }

    public async Task <SupplierDTO> GetSupplier(int Id)
    {
        SupplierModel supplierModel = _context.Suppliers.FirstOrDefault(x => x.Id == Id);

        return await Task.FromResult(_mapper.Map<SupplierDTO>(supplierModel));
    }

    public async Task<SupplierDTO> AddSupplier(SupplierDTO supplier)
    {
        SupplierModel supplierModel = _mapper.Map<SupplierModel>(supplier);

        _context.Suppliers.Add(supplierModel);
        _context.SaveChanges();

        return await Task.FromResult(_mapper.Map<SupplierDTO>(supplierModel));
    }

    public Task<SupplierDTO> UpdateSupplier(int Id, SupplierDTO supplier)
    {
        SupplierModel existingSupplierModel = _context.Suppliers.Find(Id);
        if (existingSupplierModel == null)
        {
            throw new Exception($"Supplier ({Id}) not found");
        }

        //update existingSupplierModel with new values
        existingSupplierModel.FirstName = supplier.FirstName;
        existingSupplierModel.LastName = supplier.LastName;
        existingSupplierModel.Address = supplier.Address;
        existingSupplierModel.Email = supplier.Email;
        existingSupplierModel.Phone = supplier.Phone;

        _context.SaveChanges();

        return Task.FromResult(_mapper.Map<SupplierDTO>(existingSupplierModel)); 
    }

    

    public async Task<bool> DeleteSupplier(int Id)
    {
        SupplierModel supplierModel = _context.Suppliers.FirstOrDefault(x => x.Id == Id);

        if (supplierModel == null)
        {
            return await Task.FromResult(false);
        }

        _context.Suppliers.Remove(supplierModel);
        _context.SaveChanges();

        return await Task.FromResult(true);
    }


    
}
