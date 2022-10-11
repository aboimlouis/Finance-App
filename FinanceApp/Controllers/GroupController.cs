using FinanceApp.Domain.DTOs.Group.Requests;
using FinanceApp.Domain.DTOs.Group.Responses;
using FinanceApp.Services.Group.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FinanceApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GroupController : ControllerBase
    {
        private readonly ILogger<GroupController> _logger;
        private IPostGroupService _postCompleteGroupService { get; set; }
        private IListGroupService _listCompleteGroupService { get; set; }

        public GroupController(ILogger<GroupController> logger, IPostGroupService postCompleteGroupService, IListGroupService listCompleteGroupService)
        {
            _logger = logger;
            _postCompleteGroupService = postCompleteGroupService;
            _listCompleteGroupService = listCompleteGroupService;
        }

        [HttpGet]
        public async Task<ActionResult<string>> Get()
        {
            return Ok(await _listCompleteGroupService.ListGroup());
        }

        [HttpPost]
        public async Task<ActionResult<string>> Post(PostGroupRequest request)
        {
            await _postCompleteGroupService.PostGroup(request.Group);
            return Ok();
        }
    }
}