using HZS.Models;

namespace BusinessLogic.Services;

public class UserService : IUserService
{
    public User AddUser(Guid Id, AddUser AddRequest)
    {
        throw new NotImplementedException();
    }

    public void DeleteUser(Guid id)
    {
        throw new NotImplementedException();
    }

    public List<User> Get()
    {
        List<User> list = new List<User>(){
            new User(){
                Id = Guid.NewGuid()
            },
            new User(){
                Id = Guid.NewGuid()
            }
        };
        return list;
    }

    public User Update(Guid id, PutUser updateRequest)
    {
        throw new NotImplementedException();
    }
}