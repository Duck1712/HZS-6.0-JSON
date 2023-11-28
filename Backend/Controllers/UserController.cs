using BusinessLogic.Services;
using FleetManager.Models;
using Microsoft.AspNetCore.Mvc;

namespace HZS.Controllers{
    [ApiController]
    [Route("[controller]")]
    public UserController : ControllerBase{
        private readonly ILogger<UserController> _logger;
        private IUserService _UserService;

        public UserController(ILogger<UserController> logger)
        {
            _logger = logger;
            _UserService = new UserService();
        }

        [HttpGet(Name = "GetAllUsers")]
        public ActionResult Get()
        {
            throw new NotImplementedException();
        }

        [HttpPut("{id}",Name ="UpdateUser")]
        public ActionResult Update(Guid id, PutUser updateRequest)
        {
            throw new NotImplementedException();
        }

        [HttpPost(Name = "AddUser")]
        public ActionResult Add()
        {
            throw new NotImplementedException();
        }

        [HttpDelete("{id}",Name ="DeleteUser")]
        public ActionResult Update(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}