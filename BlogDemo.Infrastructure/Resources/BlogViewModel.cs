using System;

namespace BlogEFSqt.Infrastructure.Resources
{
    public class BlogViewModel
    {
        public int Id { get; set; }

        public string Title { get; set; }
        public string Conent { get; set; }
        public string Submiter { get; set; }
        public DateTime UpdateDate { get; set; }

        public string Remark { get; set; }
    }
}
