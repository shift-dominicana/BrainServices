using AutoMapper;
using BussinesLayer.Interfaces.Genres;
using BussinesLayer.Repositories.Core;
using DataLayer.Contexts;
using DataLayer.Models.Genres;
using DataLayer.ViewModels.Genres;

namespace BussinesLayer.Services.Genres
{
    public class GenresService : Repository<Genre, GenreViewModel, MainDbContext>, IGenresService
    {
        public GenresService(MainDbContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
