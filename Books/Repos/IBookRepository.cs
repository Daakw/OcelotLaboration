namespace Books.Repos
{
    public interface IBookRepository
    {
        public Task<List<Book>> GetAllBooks();
        public Task<Book> AddBook(Book book);
    }
}
