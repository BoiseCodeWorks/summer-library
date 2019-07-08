namespace library.Models
{
    class Publication
    {
        public string Title { get; set; }
        public bool Available { get; set; }
        public int Pages { get; set; }

        public Publication(string title, int pages)
        {
            Title = title;
            Pages = pages;
            Available = true;
        }
    }
}