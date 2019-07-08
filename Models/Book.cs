namespace library.Models
{
    class Book : Publication
    {
        public string Author { get; set; }
        public Book(string title, int pages, string author) : base(title, pages)
        {
            Author = author;
        }


    }
}