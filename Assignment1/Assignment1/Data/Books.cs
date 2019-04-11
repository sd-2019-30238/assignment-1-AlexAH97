using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    
    public class Books
    {
        public int Id { get; set; }
        public String Author { get; set; }
        public String Title { get; set; }
        public String Genre { get; set; }
        public DateTime ReleaseDate { get; set; }
        public bool Available { get; set; }
        public Books()
        {
            
        }
        public Books(int Id,String Author,String Title,String Genre,DateTime ReleaseDate,bool Available)
        {
            this.Id = Id;
            this.Author = Author;
            this.Title = Title;
            this.Genre = Genre;
            this.ReleaseDate = ReleaseDate;
            this.Available = Available;
        }
        

    }

}
