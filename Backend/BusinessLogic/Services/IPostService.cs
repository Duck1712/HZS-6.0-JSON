using HZS.Models;

namespace BusinessLogic.Services;

public interface IPostService
{
    List<Post> GetAllPosts();
    Post GetById(Guid Id);
    Post Add(Post Post);
    void Delete(Guid id);

}