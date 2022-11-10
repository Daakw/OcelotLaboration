using Books.Repos;
using Microsoft.AspNetCore.Mvc;

namespace Books.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookRepository _bookRepository;
        public BookController(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        [HttpGet]
        public async Task<ActionResult<List<Book>>> GetAllBooks()
        {
            return await _bookRepository.GetAllBooks();
        }

        [HttpPost]
        public async Task<ActionResult<Book>> AddBook(Book book)
        {
            return await _bookRepository.AddBook(book);
        }
    }
}
