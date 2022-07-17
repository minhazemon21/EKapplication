using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EKapp.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public string Actress { get; set; }
        public int Budget { get; set; }
        public int Earning { get; set; }
    }
}