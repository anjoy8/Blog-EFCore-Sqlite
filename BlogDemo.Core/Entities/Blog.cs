using System;
using System.Collections.Generic;
using System.Text;

namespace BlogEFSqt.Core.Entities
{
    public class Blog: Entity
    {
        public string Title { get; set; }
        public string Conent { get; set; }
        public string Submiter { get; set; }
        public DateTime UpdateDate { get; set; }

        public string Remark { get; set; }
    }
}
