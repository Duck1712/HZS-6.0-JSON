using HZS.Models;
using System.Xml.Linq;

namespace BusinessLogic.Services{
    public interface IUserService{
        List<User> Get();
        User Update(Guid id, PutUser updateRequest);
        User AddUser(Guid id, AddUser AddRequest);
        void DeleteUser(Guid id);
        User UpdateXp(Guid id, PutUserXp updateRequest);
        User GetById(Guid id);
    }
}