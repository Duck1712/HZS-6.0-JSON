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
        public void Update(Guid id, PutUser updateRequest)
        {
            _userService.Update(id, updateRequest);
        }

        [HttpPost(Name = "AddUser")]
        public void Add(AddUser AddRequest)
        {
            _userService.AddUser(AddRequest);
        }

        [HttpDelete("{id}",Name ="DeleteUser")]
        public void Delete(Guid id)
        {
            _userService.DeleteUser(id);
        }

        [HttpPut("{id}/xp",Name ="UpdateUserXp")]
        public void UpdateXp(Guid id, PutUserXp updateRequest)
        {
            _userService.UpdateXp(id, updateRequest);
        }

        [HttpGet("{id}",Name = "GetUserById")]
        public User GetUserById(Guid id)
        {
            return _userService.GetById(id);
        }
    }
}