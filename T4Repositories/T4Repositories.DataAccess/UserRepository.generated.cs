﻿// <autogenerated>
//   This file was generated by T4 code generator RepositoryScript.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using T4Repositories.Models;
using T4Repositories.Logic.Repositories;
using System;

namespace T4Repositories.DataAccess
{
	public partial class UserRepository : Repository<User>, IUserRepository
	{
		public UserRepository(Lazy<DataContext> db)
			: base(db)
			{

			}
	}
}
