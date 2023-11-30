using HZS.Models;

namespace BusinessLogic.Services;

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
        
        return db.posts.ToList();
    }

    public Post GetById(Guid id)
    {
        
        return db.posts.Find(id);
    }
}