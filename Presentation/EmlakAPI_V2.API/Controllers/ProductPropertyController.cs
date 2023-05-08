using EmlakAPI_V2.Application.Repositories;
using EmlakAPI_V2.Application.ViewModels.ProductProperties;
using EmlakAPI_V2.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace EmlakAPI_V2.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductPropertyController : ControllerBase
    {

        readonly private IProductPropertyReadRepository _productPropertyReadRepository;
        readonly private IProductPropertyWriteRepository _productPropertyWriteRepository;

        public ProductPropertyController(IProductPropertyReadRepository productPropertyReadRepository, IProductPropertyWriteRepository productPropertyWriteRepository)
        {
            _productPropertyReadRepository = productPropertyReadRepository;
            _productPropertyWriteRepository = productPropertyWriteRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProductProperties()
        {
            return Ok(_productPropertyReadRepository.GetAll(false));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProduct(string id)
        {
            return Ok(await _productPropertyReadRepository.GetByIdAsync(id, false));
        }

        [HttpPost]
        public async Task<IActionResult> Post(VM_Create_ProductProperties model)
        {
            await _productPropertyWriteRepository.AddAsync(
                new()
                {
                    Name = model.Name,
                    Description = model.Description,
                    TextValue = model.TextValue,
                    BoolValue = model.BoolValue,
                });
            await _productPropertyWriteRepository.SaveAsync();
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Put(VM_Update_ProductProperties model)
        {
            ProductProperty productProperty = await _productPropertyReadRepository.GetByIdAsync(model.Id);
            productProperty.Name = model.Name;
            productProperty.TextValue = model.TextValue;
            productProperty.BoolValue = model.BoolValue;
            productProperty.Description = model.Description;
            await _productPropertyWriteRepository.SaveAsync();
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            await _productPropertyWriteRepository.RemoveAsync(id);
            await _productPropertyWriteRepository.SaveAsync();
            return Ok();
        }
    }
}
