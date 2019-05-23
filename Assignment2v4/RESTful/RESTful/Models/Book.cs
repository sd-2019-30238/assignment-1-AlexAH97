using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RESTful.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public string ReleaseDate { get; set; }
        public Nullable<bool> Available { get; set; }
    }
}