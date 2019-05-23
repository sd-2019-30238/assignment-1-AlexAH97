using DatabaseDataAccess;
using RESTful.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RESTful.Controllers
{
    public class UsersController : ApiController
    {

        public IEnumerable<User> Get()
        {
            List<User> us = new List<User>();
            List<Users> et = new List<Users>();
            using (DataBaseEntities entities = new DataBaseEntities())
            {
                et=entities.Users.ToList();
                foreach(Users t in et)
                {
                    us.Add(new User { Id = t.Id, Username = t.Username, Password = t.Password, Email = t.Email });
                }
                return us;
            }
        }
        public User Get(int id)
        {
            Users t;
            using (DataBaseEntities entity = new DataBaseEntities())
            {
                t=entity.Users.FirstOrDefault(E => E.Id == id);
                User newUser = new User(t.Id, t.Username, t.Password, t.Email);
                return newUser;
            }
        }
        public void Post(Users user)
        {
            
            using (DataBaseEntities entity = new DataBaseEntities())
            {
                entity.Database.ExecuteSqlCommand("Insert into Users(Username,Password,Email) Values('" + user.Username + "','" + user.Password + "','" + user.Email + "')");
            }
        }
    
    }
}
        
 
