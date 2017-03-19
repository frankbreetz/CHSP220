using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ListsaAndMoreLists
{
    class Program
    {
        static void Main(string[] args)
        {
            var users = new List<Models.User>();

            users.Add(new Models.User { Name = "Dave", Password = "hello" });
            users.Add(new Models.User { Name = "Steve", Password = "steve" });
            users.Add(new Models.User { Name = "Lisa", Password = "hello" });
            var pass = from user in users
                       where user.Password == "hello"
                       select user;
                        
          // Console.WriteLine(users.Where(user => user.Password == "hello"));

            //Couldn't find away to get rid of this foreach loop. I
            //don't know if you can display using LINQ
            foreach (var p in pass){
                Console.WriteLine($"Name:{p.Name} Password:{p.Password}");
            };

            users.RemoveAll(user=>user.Name.ToLower()==user.Password.ToLower());

            users.Remove(users.First(user => user.Password == "hello"));
            foreach(Models.User user in users)
            {
                Console.WriteLine(user.Name);
            }                 
        }
        class Models
        {

            internal class User
            {
                private string name;
                private string password;
                public string Name
                {

                get
                    {
                        return name;
                    }
                    set
                    {
                        name=value;
                    }
                }
                public string Password {
                    get
                    {
                       return password ;
                    }
                    set {
                        password=value;
                    }
                }
            }
        }
    }
}
