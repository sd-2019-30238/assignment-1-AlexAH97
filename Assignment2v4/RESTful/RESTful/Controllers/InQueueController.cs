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
    public class InQueueController : ApiController
    {
        private InQueue b;
       
        public void Delete(string username,string Title)
        {
            using (DataBaseEntities entity = new DataBaseEntities())
            {
                entity.Database.ExecuteSqlCommand("Delete From InQueue Where Username='"+username+"' and Title='"+Title+"'");
            }
            
        }
        public InQueue1 Get(string Title)
        {
           
            using (DataBaseEntities entity = new DataBaseEntities())
            {
               b=entity.InQueue.FirstOrDefault(E => E.Title.Equals(Title));
                return new InQueue1 { Id = b.Id, Title = b.Title, Username = b.Username };
            }
            
        }
        public void Post(string Username, string Title)
        {
            
            using (DataBaseEntities entity = new DataBaseEntities())
            {
                entity.Database.ExecuteSqlCommand("Insert into InQueue(Username,Title) Values('" + Username + "' and Title='" + Title + "')");
            }
            
        }
    }
}
