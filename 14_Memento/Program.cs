using _14_Memento.Classes;
using _14_Memento.Entities;

Book book = new()
{
    Title = "Sefiller",
    Author = "Victor Hugo",
    Isbn = "123654789"
};
book.ShowBook();

CareTaker history = new();
history.Memento = book.CreateUndo();

book.Title = "SEFİLLER";
book.Author = "VICTOR HUGO";
book.Isbn = "654321";
book.ShowBook();

book.RestoreFromUndo(history.Memento);
book.ShowBook();