using _14_Memento.Classes;

namespace _14_Memento.Entities
{
    public class Book
    {
        private string? _title;
        private string? _author;
        private string? _isbn;
        private DateTime _lastEdited;

        private void SetLastEdited()
        {
            _lastEdited = DateTime.Now;
        }

        public Memento CreateUndo()
        {
            return new Memento(_title, _author, _isbn, _lastEdited);
        }

        public void RestoreFromUndo(Memento memento)
        {
            _title = memento.Title;
            _author = memento.Author;
            _isbn = memento.Isbn;
            _lastEdited = memento.LastEdited;
        }

        public string Title 
        { 
            get 
            { 
                return _title; 
            } 
            set
            {
                _title = value;
                SetLastEdited();
            }
        }

        public string Author
        {
            get
            {
                return _author;
            }
            set
            {
                _author = value;
                SetLastEdited();
            }
        }

        public string Isbn
        {
            get
            {
                return _isbn;
            }
            set
            {
                _isbn = value;
                SetLastEdited();
            }
        }

        public void ShowBook()
        {
            Console.WriteLine($"{Title}, {Author}, {Isbn}, edited: {_lastEdited}");
        }
    }
}