using DatabaseDataAccess;
using RESTful.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RESTful.Controllers
{
    public class BooksController : ApiController
    {
        List<Book> books;
        List<Books> b;
        public IEnumerable<Book> Get()
        {
            books = new List<Book>();
            using (DataBaseEntities entity = new DataBaseEntities())
            {
                 b = entity.Books.ToList();
                foreach(Books m in b)
                {
                    books.Add(new Book { Author = m.Author, Title = m.Title, Genre = m.Genre, Id = m.Id, Available = m.Available, ReleaseDate = m.ReleaseDate });
                }
                return books;
            }
        }
        public IEnumerable<Book> GetBooksAfterTitle(string Title)
        {
            books = new List<Book>();
            //b = new List<Books>();
            using (DataBaseEntities entity = new DataBaseEntities())
            {
                b = entity.Books.Where(E => E.Title.Contains(Title)).ToList();
                
                foreach (Books m in b)
                {
                    books.Add(new Book { Author = m.Author, Title = m.Title, Genre = m.Genre, Id = m.Id, Available = m.Available, ReleaseDate = m.ReleaseDate });
                }
                return books;
            }
        }
        public IEnumerable<Book> GetBooksAfterAuthor(string Author)
        {
            books = new List<Book>();
            using (DataBaseEntities entity = new DataBaseEntities())
            {
                b = entity.Books.Where(E => E.Title.Contains(Author)).ToList() ;
                foreach (Books m in b)
                {
                    books.Add(new Book { Author = m.Author, Title = m.Title, Genre = m.Genre, Id = m.Id, Available = m.Available, ReleaseDate = m.ReleaseDate });
                }
                return books;
            }
        }
        public IEnumerable<Book> GetBooksAfterGenre(string Genre)
        {
            books = new List<Book>();
            using (DataBaseEntities entity = new DataBaseEntities())
            {
                b = entity.Books.Where(E => E.Title.Contains(Genre)).ToList();
                foreach (Books m in b)
                {
                    books.Add(new Book { Author = m.Author, Title = m.Title, Genre = m.Genre, Id = m.Id, Available = m.Available, ReleaseDate = m.ReleaseDate });
                }
                return books;
            }
        }
        public void Post(Books books)
        {
            using (DataBaseEntities entity = new DataBaseEntities())
            {
                entity.Database.ExecuteSqlCommand("Insert into Books(Title,Author,Genre,ReleaseDate,Available) Values ('"+books.Title+ "','" + books.Author + "','" + books.Genre + "','" + books.ReleaseDate + "','" + books.Available + "')");
            }
        }
        public void setBookAvailable(string Title)
        {
            using (DataBaseEntities entity = new DataBaseEntities())
            {
                entity.Database.ExecuteSqlCommand("Set Available='1' From Books Where Title='" + Title + "'");
            }
        }
        public void setBookAvailableNot(string Title)
        {
            using (DataBaseEntities entity = new DataBaseEntities())
            {
                entity.Database.ExecuteSqlCommand("Set Available='0' From Books Where Title='" + Title + "'");
            }
        }
        
    }
}
