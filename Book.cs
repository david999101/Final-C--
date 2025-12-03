// Initializing Book class
class Book
{
    private string title;
    private string author;
    private string publishYear;

// Constructor
    public Book(string title, string author, string publishYear)
    {
        this.title = title;
        this.author = author;
        this.publishYear = publishYear;
    }

// Getters
    public string getTitle() => title;
    public string getAuthor() => author;
    public string getPublishYear() => publishYear;

// Overriding Console.WriteLine for Book object
    public override string ToString() => $"{title}, {author}, {publishYear}";

}