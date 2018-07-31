using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T4Repositories.Models;

namespace T4Repositories.DataAccess
{
    public partial class UserRepository
    {
        public User GetByUserName(string userName)
        {
            return DataContext.Users.FirstOrDefault(u => u.UserName == userName);
        }
    }
}
