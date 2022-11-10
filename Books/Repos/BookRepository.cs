namespace Books.Repos
{
    public class BookRepository : IBookRepository
    {
        private readonly List<Book> _books;
        public static BookRepository Instance;

        public BookRepository()
        {
            if (Instance == null)
            {
                Instance = this;
                _books = new List<Book>();

                _books.Add(new Book
                {
                    Id = Guid.NewGuid(),
                    Genre = "Deckare",
                    Name = "Spindeln",
                    Author = "Lars Kepler",
                    Price = 229
                });

                _books.Add(new Book
                {
                    Id = Guid.NewGuid(),
                    Genre = "Deckare",
                    Name = "Snabba Cash",
                    Author= "Jens Lapidus",
                    Price = 199
                });

                _books.Add(new Book
                {
                    Id = Guid.NewGuid(),
                    Genre = "BarnBöcker",
                    Name = "Harry Potter och de vises sten",
                    Author = "JK Rowling",
                    Price = 249
                });
            }
        }


        public Task<Book> AddBook(Book book)
        {
            Instance._books.Add(new Book
            {
                Id = book.Id,
                Genre = book.Genre,
                Name = book.Name,
                Author = book.Author,
                Price = book.Price
            });
            return Task.FromResult(book);
        }

        public Task<List<Book>> GetAllBooks()
        {
            return Task.FromResult(Instance._books);
        }
    }
}
