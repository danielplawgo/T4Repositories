using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T4Repositories.Models;

namespace T4Repositories.Logic.Repositories
{
    public partial interface IUserRepository
    {
        User GetByUserName(string userName);
    }
}
