using HZS.Models;
using System;
using System.Linq;

namespace BusinessLogic.Services;

public class UserService : IUserService
{
    Context db = new Context();
    
    public void AddUser(AddUser AddRequest)
    {
        db.users.Add(new User {
            Id = Guid.NewGuid(),
            Username = AddRequest.Username,
            Password = AddRequest.Password,
            FirstName = AddRequest.FirstName,
            LastName = AddRequest.LastName,
            Email = AddRequest.Email,
            Xp = 0
        });
        db.SaveChanges();
    }

    public void DeleteUser(Guid id)
    {
        db.Remove(db.users.Find(id));
        db.SaveChanges();
    }

    public List<User> Get()
    {
        return (db.users.OrderBy(u => u.Xp)).ToList<User>();
    }

    public void Update(Guid id, PutUser updateRequest)
    {
        var User u = db.users.Find(id);
        if (updateRequest.Password != null){
            u.Password = updateRequest.Password;
        }
        if(updateRequest.Username != null){
            u.Username = updateRequest.Username;
        }
        if(updateRequest.Email != null){
            u.Email = updateRequest.Email;
        }
        db.SaveChanges();
    }

    public void UpdateXp(Guid id, PutUserXp updateRequest){
        if(updateRequest.Xp != null){
            db.users.Find(id).Xp += updateRequest.Xp
            db.SaveChanges();
        }
    }

    public User GetById(Guid id){
        return db.users.Find(id);
    }
}