using AutoMapper;
using BussinesLayer.Interfaces.Authors;
using BussinesLayer.Repositories.Core;
using DataLayer.Contexts;
using DataLayer.Models.Authors;
using DataLayer.ViewModels.Authors;

namespace BussinesLayer.Services.Authors
{
    public class AuthorService : Repository<Author, AuthorViewModel, MainDbContext>, IAuthorService
    {
        public AuthorService(MainDbContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
