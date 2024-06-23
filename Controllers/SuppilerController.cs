using Microsoft.AspNetCore.Mvc;
using GraphQLAPI.Services;
using GraphQLAPI.Infra.Models;

namespace GraphQLAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class SupplierController : ControllerBase
{
    private readonly ISupplierService _supplierService;

    public SupplierController(ISupplierService supplierService)
    {
        _supplierService = supplierService;
    }

    [HttpGet]
    public async Task<IEnumerable<SupplierDTO>> GetSuppliers()
    {
        return await _supplierService.GetSuppliers();
    }

    [HttpGet("{id}")]
    public async Task<SupplierDTO> GetSupplier(int id)
    {
        return await _supplierService.GetSupplier(id);
    }
}