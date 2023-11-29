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
            return Ok(_userService.Get());
        }

        [HttpPut("{id}",Name ="UpdateUser")]
        public ActionResult Update(Guid id, PutUser updateRequest)
        {
            return Ok(_userService.Update());
        }

        [HttpPost(Name = "AddUser")]
        public ActionResult Add(Guid Id, AddUser AddRequest)
        {
            return Ok(_userService.AddUser());
        }

        [HttpDelete("{id}",Name ="DeleteUser")]
        public ActionResult Delete(Guid id)
        {
            _userService.DeleteUser(id);
            return Ok();
        }

        [HttpPut("{id}",Name ="UpdateUserXp")]
        public ActionResult UpdateXp(Guid id, PutUserXp updateRequest)
        {
            return Ok(_userService.UpdateXp());
        }

        [HttpGet(Name = "GetUserById")]
        public ActionResult GetUserById()
        {
            return Ok(_userService.GetById());
        }
    }
}