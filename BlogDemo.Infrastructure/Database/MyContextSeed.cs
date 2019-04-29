using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BlogEFSqt.Core.Entities;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.Logging;

namespace BlogEFSqt.Infrastructure.Database
{
    public class MyContextSeed
    {
        public static async Task SeedAsync(MyContext myContext,
                          ILoggerFactory loggerFactory, int retry = 0)
        {
            int retryForAvailability = retry;
            try
            {
                if (!myContext.Blogs.Any())
                {
                    myContext.Blogs.AddRange(
                        new List<Blog>{
                            new Blog{
                                Title = "Laozhang",
                                Conent = "老张的哲学",
                                Submiter = "lz",
                                UpdateDate = DateTime.Now,
                                Remark="phi"
                            }
                           
                        }
                    );
                    await myContext.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                if (retryForAvailability < 10)
                {
                    retryForAvailability++;
                    var logger = loggerFactory.CreateLogger<MyContextSeed>();
                    logger.LogError(ex.Message);
                    await SeedAsync(myContext, loggerFactory, retryForAvailability);
                }
            }
        }
    }
}
