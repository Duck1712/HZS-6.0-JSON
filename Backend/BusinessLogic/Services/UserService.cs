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
        throw new NotImplementedException();
    }

    public User Update(Guid id, PutUser updateRequest)
    {
        throw new NotImplementedException();
    }

    public User UpdateXp(Guid id, PutUserXp updateRequest){
        throw new NotImplementedException();
    }

    public User GetById(Guid id){
        throw new NotImplementedException();
    }
}