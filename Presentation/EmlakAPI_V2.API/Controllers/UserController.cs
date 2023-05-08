using EmlakAPI_V2.Application.Repositories;
using EmlakAPI_V2.Application.ViewModels.Users;
using EmlakAPI_V2.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace EmlakAPI_V2.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserReadRepository _userReadRepository;
        private readonly IUserWriteRepository _userWriteRepository;

        public UserController(IUserReadRepository userReadRepository, IUserWriteRepository userWriteRepository)
        {
            _userReadRepository = userReadRepository;
            _userWriteRepository = userWriteRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllUsers()
        {
            return Ok(_userReadRepository.GetAll(false));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUser(string id)
        {
            return Ok(await _userReadRepository.GetByIdAsync(id, false));
        }

        [HttpPost]
        public async Task<IActionResult> Post(VM_Create_User model)
        {
            await _userWriteRepository.AddAsync(
                new()
                {
                    Name = model.Name,
                    Adress = model.Adress,
                    Age = model.Age,
                    Gender = model.Gender,
                    Image = model.Image,
                    IsAdmin = model.IsAdmin,
                    PhoneNumber = model.PhoneNumber,
                });
            await _userWriteRepository.SaveAsync();
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Put(VM_Update_User model)
        {
            User user = await _userReadRepository.GetByIdAsync(model.Id);
            user.Name = model.Name;
            user.Adress = model.Adress;
            user.Gender = model.Gender;
            user.Image = model.Image;
            user.PhoneNumber = model.PhoneNumber;
            user.IsAdmin = model.IsAdmin;
            user.Age = model.Age;
            await _userWriteRepository.SaveAsync();
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            await _userWriteRepository.RemoveAsync(id);
            await _userWriteRepository.SaveAsync();
            return Ok();
        }
    }
}
