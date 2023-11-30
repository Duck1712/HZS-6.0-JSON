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
        public List<Post> GetAllPosts()
        {
           return _postService.GetAllPosts();
        }

        [HttpGet("{id}",Name = "GetById")]
        public Post GetById(Guid id)
        {
            return _postService.GetById(id);
        }

        [HttpPost(Name ="Add")]
        public void Post(AddPost addRequest)
        {
            addRequest.Id = Guid.NewGuid();
            _postService.Add(addRequest);
        }

        [HttpDelete("{id}", Name = "DeletePost")]
        public void Delete(Guid id)
        {
            _postService.Delete(id);
        }
        
    }
}