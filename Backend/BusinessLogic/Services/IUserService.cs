using HZS.Models;
using System.Xml.Linq;

namespace BusinessLogic.Services{
    public interface IUserService{
        List<User> Get();
        User Update(Guid id, PutUser updateRequest);
        User AddUser(Guid Id, AddUser AddRequest);
        void DeleteUser(Guid id);
    }
}