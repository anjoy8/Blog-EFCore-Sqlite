using AutoMapper;
using BlogEFSqt.Core.Interfaces;
using BlogEFSqt.Infrastructure.Database;
using BlogEFSqt.Infrastructure.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace BlogEFSqt.Api
{
    public class Startup
    {
        //0、将 BlogEFSqt.Api 设置为启动项
        //1、在 Package Manager Console 切换到 BlogEFSqt.Infrastructure
        //2、执行 add-migration init，生产迁移
        //3、执行 update-database 生成 WMBlog.db 数据库
        //4、启动项目，自动生成 seed 数据
        private static IConfiguration Configuration { get; set; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
           
            services.AddMvc();

            services.AddDbContext<MyContext>(options =>
            {
                var connectionString = Configuration["ConnectionStrings:DefaultConnection"];
                options.UseSqlite(connectionString);
            });


            services.AddAutoMapper();

            services.AddScoped<IBlogRepository, BlogRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();

        }

        public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
        {

            app.UseMvc();
        }
    }
}
