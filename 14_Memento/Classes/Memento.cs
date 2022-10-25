namespace _14_Memento.Classes
{
    public class Memento
    {
        public string? Title { get; set; }
        public string? Author { get; set; }
        public string? Isbn { get; set; }
        public DateTime LastEdited { get; set; }

        public Memento(string title, string author, string isbn, DateTime lastEdited)
        {
            Title = title;
            Author = author;
            Isbn = isbn;
            LastEdited = lastEdited;
        }
    }
}