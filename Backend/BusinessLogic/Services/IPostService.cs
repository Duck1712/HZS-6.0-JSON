using HZS.Models;

namespace BusinessLogic.Services;

public interface IPostService
{
    List<Post> GetAllPosts();
    Post GetById(Guid Id);
    void Add(AddPost addRequest);
    void Delete(Guid id);

}