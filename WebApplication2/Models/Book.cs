namespace WebApplication2.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Serial { get; set; }
        public string Name { get; set; }
        public GenreEnum Genre { get; set; }
    }
}
