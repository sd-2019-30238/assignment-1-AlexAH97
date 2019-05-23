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
    public class LibraryController : ApiController
    {
        private List<Library1> FuckingBooks;
        private List<Library> b;
        private BooksController booksController;
        private UsersController usersController;
        private InQueueController inQueueController;
        public LibraryController()
        {
            booksController = new BooksController();
            usersController = new UsersController();
            inQueueController = new InQueueController();
        }
        public void Post(string username, string Title)
        {

            Book book = (Book)booksController.GetBooksAfterTitle(Title);

            if (book.Available == true)
            {
                using (DataBaseEntities entity = new DataBaseEntities())
                {
                    entity.Database.ExecuteSqlCommand("Insert into Library(Username,BookTitle) Values('" + username + "','" + Title + "');");
                    booksController.setBookAvailableNot(Title);
                }
            }
            else
            {
                inQueueController.Post(username, Title: Title);
            }
        }
        public IEnumerable<Library1> Get(string Username)
        {
            FuckingBooks = new List<Library1>();
            using (DataBaseEntities entity = new DataBaseEntities())
            {
                b=entity.Library.Where(E => E.Username.Equals(Username)).ToList();

                foreach(Library m in b){
                    FuckingBooks.Add(new Library1 { Id = m.Id, BookTitle = m.BookTitle, Username = m.Username });
                }
                return FuckingBooks;
            }
        }
        public IEnumerable<Library1> Get()
        {
            FuckingBooks = new List<Library1>();
            using (DataBaseEntities entity = new DataBaseEntities())
            {
                 b=entity.Library.ToList();
                foreach (Library m in b)
                {
                    FuckingBooks.Add(new Library1 { Id = m.Id, BookTitle = m.BookTitle, Username = m.Username });
                }
                return FuckingBooks;
            }
        }

        public void Delete(string username,string Title)
        {
            InQueue1 inQueue = new InQueue1();
            inQueue = inQueueController.Get(Title);
            if(inQueue.Title == null)
            {
                booksController.setBookAvailable(Title);
                using (DataBaseEntities entity = new DataBaseEntities())
                {
                    entity.Database.ExecuteSqlCommand("Delete From Library Where Username='"+username+"' and BookTitle='"+Title+"'");
                }
            }
            else
            {
                using (DataBaseEntities entity = new DataBaseEntities())
                {
                    entity.Database.ExecuteSqlCommand("Delete From Library Where Username='" + username + "' and BookTitle='" + Title + "'");
                    Post(inQueue.Username, Title);
                    inQueueController.Delete(username,Title);
                }
            }
            
        }

        

            
    }
}
