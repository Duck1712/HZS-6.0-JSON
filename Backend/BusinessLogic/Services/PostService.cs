using HZS.Models;

namespace BusinessLogic.Services;
using System;
using System.Linq;

public class PostService : IPostService
{
    Context db = new Context();
    public void Add(AddPost updateRequest)
    {
        db.posts.Add(new Post {
            Id = Guid.NewGuid(),
            Title = updateRequest.Title,
            Content = updateRequest.Content,
            Sport = updateRequest.Sport,
            UserId = updateRequest.UserId,
            user = updateRequest.user
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

    public Post GetById(Guid Id)
    {
        return db.posts.Find(id);
    }
}