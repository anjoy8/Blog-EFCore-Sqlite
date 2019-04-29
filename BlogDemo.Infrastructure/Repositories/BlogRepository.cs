using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogEFSqt.Core.Entities;
using BlogEFSqt.Core.Interfaces;
using BlogEFSqt.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;

namespace BlogEFSqt.Infrastructure.Repositories
{
    public class BlogRepository : IBlogRepository
    {
        private readonly MyContext _myContext;

        public BlogRepository(MyContext myContext)
        {
            _myContext = myContext;
        }



        public Task<Blog> GetBlogByIdAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public void AddBlog(Blog blog)
        {
            throw new System.NotImplementedException();
        }
        public void Delete(Blog blog)
        {
            _myContext.Blogs.Remove(blog);
        }

        public void Update(Blog blog)
        {
            _myContext.Entry(blog).State = EntityState.Modified;
        }

        public Task<List<Blog>> GetAllBlogsAsync()
        {
            return _myContext.Blogs.AsQueryable().ToListAsync();
        }

    }
}
