using AutoMapper;
using BussinesLayer.Interfaces.Books;
using BussinesLayer.Repositories.Core;
using DataLayer.Contexts;
using DataLayer.Models.Books;
using DataLayer.ViewModels.Books;

namespace BussinesLayer.Services.Books
{
    public class BooksService : Repository<Book, BookViewModel, MainDbContext>, IBooksService
    {
        public BooksService(MainDbContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
