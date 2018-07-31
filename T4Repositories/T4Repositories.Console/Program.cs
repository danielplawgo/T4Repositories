using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T4Repositories.DataAccess;
using T4Repositories.Logic.Repositories;

namespace T4Repositories.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new DataContext())
            {
                string userName = string.Empty;

                IUserRepository userRepository = new UserRepository(new Lazy<DataContext>(() => db));

                var users = userRepository.GetAll();

                foreach (var user in users)
                {
                    System.Console.WriteLine(user.UserName);

                    userName = user.UserName;
                }

                var lastUser = userRepository.GetByUserName(userName);

                if (lastUser != null)
                {
                    System.Console.WriteLine("Last user: {0}", lastUser.UserName);
                }
            }
        }
    }
}
