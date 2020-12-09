using BussinesLayer.Repositories.Core;
using DataLayer.Models.User;
using DataLayer.ViewModels.Users;

namespace BussinesLayer.Interfaces.Users
{
    public interface IUsersService : IRepository<User, UserViewModel>
    {

    }
}
