namespace Books
{
    public class Book
    {
        public Guid Id { get; set; }
        public string Genre { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public int Price { get; set; }
    }
}