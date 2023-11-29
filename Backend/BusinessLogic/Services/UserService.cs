using HZS.Models;
using System;
using System.Linq;

namespace BusinessLogic.Services;

public class UserService : IUserService
{
    Context db = new Context();
    
    public void AddUser(AddUser AddRequest)
    {
        var query = from user in db.users
                    where user.Username == AddRequest.Username
                    select user;
        if(query.Any()){
            return;
        }
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
        if (updateRequest.Password != null){
            db.users.Find(id).Password = updateRequest.Password;
        }
        if(updateRequest.Username != null){
            db.users.Find(id).Username = updateRequest.Username;
        }
        if(updateRequest.Email != null){
            db.users.Find(id).Email = updateRequest.Email;
        }
        db.SaveChanges();
    }

    public void UpdateXp(Guid id, PutUserXp updateRequest){
        if(updateRequest.Xp != null){
            db.users.Find(id).Xp += updateRequest.Xp;
            db.SaveChanges();
        }
    }

    public User GetById(Guid id){
        return db.users.Find(id);
    }
}