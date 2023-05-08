using EmlakAPI_V2.Application.Repositories;
using EmlakAPI_V2.Application.ViewModels.Comments;
using EmlakAPI_V2.Domain.Entities;
using EmlakAPI_V2.Persistence.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace EmlakAPI_V2.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        ICommentReadRepository _commentReadRepository { get; set; }
        ICommentWriteRepository _commentWriteRepository { get; set; }

        public CommentController(ICommentReadRepository commentReadRepository, ICommentWriteRepository commentWriteRepository)
        {
            _commentReadRepository = commentReadRepository;
            _commentWriteRepository = commentWriteRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllComments()
        {
            return Ok(_commentReadRepository.GetAll(false));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetComment(string id)
        {
            return Ok(await _commentReadRepository.GetByIdAsync(id, false));
        }

        [HttpPost]
        public async Task<IActionResult> Post(VM_Create_Comment model)
        {
            await _commentWriteRepository.AddAsync(
                new()
                {
                    CommentText = model.CommentText,
                    CommentTitle = model.CommentTitle,
                    IsEdited = model.IsEdited,
                    Rating = model.Rating,
                });
            await _commentWriteRepository.SaveAsync();
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Put(VM_Update_Comment model)
        {
            Comment comment = await _commentReadRepository.GetByIdAsync(model.Id);
            comment.CommentText = model.CommentText;
            comment.CommentTitle = model.CommentTitle;
            comment.IsEdited = true;
            comment.Rating = model.Rating;
            await _commentWriteRepository.SaveAsync();
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            await _commentWriteRepository.RemoveAsync(id);
            await _commentWriteRepository.SaveAsync();
            return Ok();
        }
    }
}
