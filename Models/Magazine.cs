namespace library.Models
{
    class Magazine : Publication
    {
        public int Issue { get; set; }
        public string MainTopic { get; set; }
        public Magazine(string title, int pages, int issue, string topic) : base(title, pages)
        {
            Issue = issue;
            MainTopic = topic;
        }
    }
}