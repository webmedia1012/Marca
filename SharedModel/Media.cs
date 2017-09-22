using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedModel
{
    public class Media
    {
        public int Id { get; set; }
        public int MediaType { get; set; }
        public string Title { get; set; }
        public string MetaDesc { get; set; }
        public int IsPublished { get; set; }
        public int PublishId { get; set; }
        public string Format { get; set; }
        public DateTime Duration { get; set; }
        public string EditInfo { get; set; }
    }
}
