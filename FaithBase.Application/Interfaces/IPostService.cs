using FaithBase.Application.Models.Post;

namespace FaithBase.Application.Interfaces
{
    public interface IPostService
    {
        void AddPost(PostInputModel model);
    }
}