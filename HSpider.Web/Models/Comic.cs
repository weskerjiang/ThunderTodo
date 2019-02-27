using System;
using System.Collections.Generic;

namespace HSpider.Web.Models
{
    public partial class Comic
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public DateTime GrabDate { get; set; }
        public int Downloaded { get; set; }
    }
}
