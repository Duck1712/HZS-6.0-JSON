using HZS.Models;
using System.Xml.Linq;

namespace BusinessLogic.Services{
    public interface IUserService{
        List<User> Get();
        User Update(Guid id, PutUser updateRequest);
        void AddUser(AddUser AddRequest);
        void DeleteUser(Guid id);
        void UpdateXp(Guid id, PutUserXp updateRequest);
        void GetById(Guid id);
    }
}