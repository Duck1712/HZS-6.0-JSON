using BusinessLogic.Services;
using HZS.Models;
using Microsoft.AspNetCore.Mvc;

namespace HZS.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PostController : ControllerBase
    {
        private readonly ILogger<PostController> _logger;

        private IPostService _postService;
        
        public PostController(ILogger<PostController> logger)
        {
            _logger = logger;
            _postService = new PostService();
        }

        [HttpGet]
        public ActionResult GetAllPosts()
        {
           throw new NotImplementedException();
        }

        [HttpGet("{id}",Name = "GetById")]
        public ActionResult GetById(Guid Id)
        {
            throw new NotImplementedException();
        }

        [HttpGet("User/{userId}",Name ="PostsByUserId")]
        public IActionResult PostsByUserId()
        {
            throw new NotImplementedException();
        }

        [HttpPost(Name ="AddLog")]
        public IActionResult Post(Post Post)
        {
            Post.Id = Guid.NewGuid();
            throw new NotImplementedException();
        }

        [HttpDelete("{id}", Name = "DeletePost")]
        public ActionResult Delete(Guid id)
        {
            throw new NotImplementedException();
        }
        
    }
}