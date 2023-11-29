using HZS.Models;
using System.Xml.Linq;

namespace BusinessLogic.Services{
    public interface IUserService{
        List<User> Get();
        void Update(Guid id, PutUser updateRequest);
        void AddUser(AddUser AddRequest);
        void DeleteUser(Guid id);
        void UpdateXp(Guid id, PutUserXp updateRequest);
        User GetById(Guid id);
    }
}