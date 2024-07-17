namespace OnlineBookstore.Models
{
    public class Book
    {
        public int BookID { get; set; }
        public string Title { get; set; }
        public int AuthorID { get; set; }
        public int CategoryID { get; set; }
        public int Price { get; set; }
        public int CoverImage { get; set; }
        public int Description { get; set; }
        public int AmountInStock { get; set; }
    }
}
