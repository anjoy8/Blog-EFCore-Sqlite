using System.Collections.Generic;
using System.Threading.Tasks;
using BlogEFSqt.Core.Entities;

namespace BlogEFSqt.Core.Interfaces
{
    public interface IBlogRepository
    {
        Task<List<Blog>> GetAllBlogsAsync();
        Task<Blog> GetBlogByIdAsync(int id);
        void AddBlog(Blog blog);
        void Delete(Blog blog);
        void Update(Blog blog);
    }
}