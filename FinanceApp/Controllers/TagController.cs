using FinanceApp.Domain.DTOs.Tag.Requests;
using FinanceApp.Services.Tag.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FinanceApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TagController : ControllerBase
    {
        private readonly ILogger<TagController> _logger;
        private IPostTagService _postCompleteTagService { get; set; }
        private IListTagService _listCompleteTagService { get; set; }

        public TagController(ILogger<TagController> logger, IPostTagService postCompleteTagService, IListTagService listCompleteTagService)
        {
            _logger = logger;
            _postCompleteTagService = postCompleteTagService;
            _listCompleteTagService = listCompleteTagService;
        }

        [HttpGet]
        public async Task<ActionResult<string>> Get()
        {
            return Ok(await _listCompleteTagService.ListTag());
        }

        [HttpPost]
        public async Task<ActionResult<string>> Post(PostTagRequest request)
        {
            await _postCompleteTagService.PostTag(request.Tag);
            return Ok();
        }
    }
}