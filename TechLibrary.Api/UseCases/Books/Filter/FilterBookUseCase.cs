using Swashbuckle.AspNetCore.SwaggerGen;
using TechLibrary.Api.Domain.Entities;
using TechLibrary.Api.Infraestructure.DataAcess;
using TechLibrary.Communication.Requests;
using TechLibrary.Communication.Responses;

namespace TechLibrary.Api.UseCases.Books.Filter
{
    public class FilterBookUseCase
    {
        private const int PAGE_SIZE = 10;
        public ResponseBooksJson Execute(RequestFilterBooksJson request)
        {
            var dbContext = new TechLibraryDbContext();

            var skip = (request.PageNumber - 1) * PAGE_SIZE;

           
            
            var query = dbContext.Books.AsQueryable();


            if (string.IsNullOrEmpty(request.Title) == false)
            {
                query = query.Where(book => book.Title.Contains(request.Title));
            }

            var books = query
                .OrderBy(book => book.Title)
                .Skip(skip)
                .Take(PAGE_SIZE)
                .ToList();

            var totalCount = dbContext.Books.Count(books => books.Title.Contains(request.Title));

            if(string.IsNullOrWhiteSpace(request.Title) == false)
            {
                totalCount = query.Count();
            }
            return new ResponseBooksJson
                {
                    Pagination = new ResponsePaginationJson
                    {
                        PageNumber = request.PageNumber,
                        TotalCount = totalCount
                    },

                    Books = query.Select(book => new ResponseBookJson
                    {
                        Id = book.Id,
                        Title = book.Title,
                        Author = book.Author
                    }).ToList()
                };
        }
    }
}
