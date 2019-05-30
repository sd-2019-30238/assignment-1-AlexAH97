using Assignment1.CQRS.Commands;
using Assignment1.CQRS.Query;
using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.CQRS
{
    class Books1
    {
        public int Id { get; set; }
        public String Author { get; set; }
        public String Title { get; set; }
        public String Genre { get; set; }
        public DateTime ReleaseDate { get; set; }
        public bool Available { get; set; }
        Broker eb;
        public Books1(Broker eb)
        {
            this.eb = eb;

            //Query
            eb.queries += IdCommand;
            eb.queries += AuthorQuery;
            eb.queries += TitleQuery;
            eb.queries += GenreQuery;
            eb.queries += GetAll;

            //Commands
            eb.commands += IdCommand1;
            eb.commands += AuthorCommand;
            eb.commands += TitleCommand;
            eb.commands += GenreCommand;
            eb.commands += SetAvailable;
        }

        private void SetAvailable(object sender, Command e)
        {
            var ac = e as AvailableCommand;
            if (ac != null)
                Console.WriteLine("Mission Done...");

        }

        private DataTable GetAll(object sender, Query e)
        {
            var ac = e as GetAllFromDatabase;
            if (ac != null)
                return ac.View;
            return new DataTable();
        }

        private void GenreCommand(object sender, Command e)
        {
            var ac = e as GenreCommand1;
            if (ac.Target == this && ac != null)
            {
                Genre = ac.Genre;
            }
        }

        private void TitleCommand(object sender, Command e)
        {
            var ac = e as TitleCommand1;
            if (ac.Target == this && ac != null)
            {
                Title = ac.Title;
            }
        }

        private void AuthorCommand(object sender, Command e)
        {
            var ac = e as AuthorCommand1;
            if (ac.Target == this && ac != null)
            {
                Author = ac.Author;
            }
        }

        private void IdCommand1(object sender, Command e)
        {
            var ac = e as IdCommand1C;
            if(ac.Target==this && ac!=null)
            {
                Id = ac.Id;
            }
        }

        private void GenreQuery(object sender, Query e)
        {
            var ac = e as GetGenreTitle;
            if (ac.Target == this && ac != null)
            {
                ac.result = Genre;
            }
        }

        private void TitleQuery(object sender, Query e)
        {
            var ac = e as GetTitleQuery;
            if (ac.Target == this && ac != null)
            {
                ac.result = Title;
            }
        }

        private void AuthorQuery(object sender, Query e)
        {
            var ac = e as GetAuthorQuery;
            if (ac.Target == this && ac != null)
            {
                ac.result = Author;
            }
        }

        private void IdCommand(object sender, Query e)
        {
            var ac = e as IdCommand;
            if(ac.Target==this && ac!=null)
            {
                ac.result = Id;
            }
        }
    }


    
    
}
