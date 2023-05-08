using EmlakAPI_V2.Application.Repositories;
using EmlakAPI_V2.Application.ViewModels.ProductTypes;
using EmlakAPI_V2.Domain.Entities;
using EmlakAPI_V2.Persistence.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace EmlakAPI_V2.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductTypeController : ControllerBase
    {
        readonly private IProductTypeReadRepository _productTypeReadRepository;
        readonly private IProductTypeWriteRepository _productTypeWriteRepository;

        public ProductTypeController(IProductTypeReadRepository productTypeReadRepository, IProductTypeWriteRepository productTypeWriteRepository)
        {
            _productTypeReadRepository = productTypeReadRepository;
            _productTypeWriteRepository = productTypeWriteRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProductTypes()
        {
            return Ok(_productTypeReadRepository.GetAll(false));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetType(string id)
        {
            return Ok(await _productTypeReadRepository.GetByIdAsync(id, false));
        }

        [HttpPost]
        public async Task<IActionResult> Post(VM_Create_ProductType model)
        {
            await _productTypeWriteRepository.AddAsync(
                new()
                {
                    Name = model.Name,
                });
            await _productTypeWriteRepository.SaveAsync();
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Put(VM_Update_ProductType model)
        {
            ProductType productType = await _productTypeReadRepository.GetByIdAsync(model.Id);
            productType.Name = model.Name;
            await _productTypeWriteRepository.SaveAsync();
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            await _productTypeWriteRepository.RemoveAsync(id);
            await _productTypeWriteRepository.SaveAsync();
            return Ok();
        }
    }
}
