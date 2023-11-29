using HZS.Models;

namespace BusinessLogic.Services;
using System;
using System.Linq;

public class PostService : IPostService
{
    Context db = new Context();
    public void Add(AddPost AddRequest)
    {
        db.posts.Add(new Post {
            Id = Guid.NewGuid(),
            Title = AddRequest.Title,
            Content = AddRequest.Content,
            Sport = AddRequest.Sport,
            UserId = AddRequest.UserId,
            user = AddRequest.user
        });
        db.SaveChanges();
    }

    public void Delete(Guid id)
    {
        db.Remove(db.posts.Find(id));
        db.SaveChanges();
    }

    public List<Post> GetAllPosts()
    {
        return (db.posts).ToList<Post>();
    }

    public Post GetById(Guid id)
    {
        return db.posts.Find(id);
    }
}