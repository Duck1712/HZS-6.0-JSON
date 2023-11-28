using BusinessLogic.Services;
using HZS.Models;
using Microsoft.AspNetCore.Mvc;

namespace HZS.Controllers{
    [ApiController]
    [Route("[controller]")]
    public class UserController{
        private readonly ILogger<UserController> _logger;
        private IUserService _userService;

        public UserController(ILogger<UserController> logger)
        {
            _logger = logger;
            _userService = new UserService();
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
        public ActionResult Add(Guid Id, AddUser AddRequest)
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