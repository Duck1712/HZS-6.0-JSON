using HZS.Models;

namespace BusinessLogic.Services;

public interface IPostService
{
    List<Post> GetAllPosts();
    Post GetById(Guid Id);
    List<Post> GetLogsByCarId();
    Post Add(Post Post);
    void Delete(Guid id);

}