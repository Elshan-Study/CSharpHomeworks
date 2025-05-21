namespace Library;

public enum Genre
{
    Fiction,
    NonFiction,
    Science,
    History,
    Fantasy
}

public class Book
{
    public string Title;
    public string Author;
    public Genre Genre;
    public bool IsAvailable = true;

    public Book(string title, string author, Genre genre)
    {
        Title = title;
        Author = author;
        Genre = genre;
    }

    public override string ToString()
    {
        return $"{Title} by {Author} ({Genre}) - {(IsAvailable ? "Available" : "Borrowed")}";
    }
}
