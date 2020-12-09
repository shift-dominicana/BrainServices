using AutoMapper;
using BussinesLayer.Interfaces.Users;
using BussinesLayer.Repositories.Core;
using DataLayer.Contexts;
using DataLayer.Models.User;
using DataLayer.ViewModels.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer.Services.Users
{
    public class UsersService : Repository<User, UserViewModel, MainDbContext>, IUsersService
    {
        public UsersService(MainDbContext context, IMapper mapper) : base(context, mapper)
        {

        }
    }
}
