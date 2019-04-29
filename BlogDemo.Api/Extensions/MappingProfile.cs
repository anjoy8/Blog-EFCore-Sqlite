using AutoMapper;
using BlogEFSqt.Core.Entities;
using BlogEFSqt.Infrastructure.Resources;

namespace BlogEFSqt.Api.Extensions
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<Blog, BlogViewModel>()
                .ForMember(dest => dest.UpdateDate, opt => opt.MapFrom(src => src.UpdateDate));

            CreateMap<BlogViewModel, Blog>();
        }
    }
}
