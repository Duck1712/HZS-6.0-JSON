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
        public List<User> Get()
        {
            return _userService.Get();
        }

        [HttpPut("{id}",Name ="UpdateUser")]
        public User Update(Guid id, PutUser updateRequest)
        {
            return _userService.Update(id, updateRequest);
        }

        [HttpPost(Name = "AddUser")]
        public User Add(Guid id, AddUser AddRequest)
        {
            return _userService.AddUser(id, AddRequest);
        }

        [HttpDelete("{id}",Name ="DeleteUser")]
        public void Delete(Guid id)
        {
            _userService.DeleteUser(id);
        }

        [HttpPut("{id}/xp",Name ="UpdateUserXp")]
        public User UpdateXp(Guid id, PutUserXp updateRequest)
        {
            return _userService.UpdateXp(id, updateRequest);
        }

        [HttpGet("{id}",Name = "GetUserById")]
        public User GetUserById(Guid id)
        {
            return _userService.GetById(id);
        }
    }
}