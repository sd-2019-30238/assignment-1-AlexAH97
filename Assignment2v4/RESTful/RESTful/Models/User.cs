using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RESTful.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public User()
        {
            Id = 0;
            Username = string.Empty;
            Password = string.Empty;
            Email = string.Empty;
        }
        public User(int Id,string Username,string Passaword,string Email)
        {
            this.Id = Id;
            this.Username = Username;
            this.Password = Password;
            this.Email = Email;
        }
    }
}