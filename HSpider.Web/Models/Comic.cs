using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HSpider.Web.Models
{
    public class Comic
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public DateTime GrabDate { get; set; }
        public int Downloaded { get; set; }
    }
}
