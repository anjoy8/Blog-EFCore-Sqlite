using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BlogEFSqt.Core.Entities;
using BlogEFSqt.Core.Interfaces;
using BlogEFSqt.Infrastructure.Resources;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace BlogEFSqt.Api.Controllers
{
    [Route("api/blogs")]
    public class BlogController : Controller
    {
        private readonly IBlogRepository _blogRepository;
        private readonly IMapper _mapper;

        public BlogController(
            IBlogRepository blogRepository,
            IMapper mapper)
        {
            _blogRepository = blogRepository;
            _mapper = mapper;
        }


        [HttpGet]
        public async Task<IActionResult> Get(BlogViewModel blogViewModel)
        {

            var blogList = await _blogRepository.GetAllBlogsAsync();

            var blogResources = _mapper.Map<IEnumerable<Blog>, IEnumerable<BlogViewModel>>(blogList);


            return Ok(blogResources);
        }

      
    }
}
