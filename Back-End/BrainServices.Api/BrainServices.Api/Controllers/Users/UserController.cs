using BussinesLayer.Interfaces.Users;
using DataLayer.Models.User;
using DataLayer.ViewModels.Users;
using Microsoft.AspNetCore.Mvc;
using WebApi.Controllers.Core;

namespace BrainServices.Api.Controllers.Users
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : CoreController<IUsersService, User, UserViewModel>
    {
        public UserController(IUsersService service) : base(service)
        {
                
        }
    }
}
