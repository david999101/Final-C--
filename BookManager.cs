class BookManager
{
    private Dictionary<string, string[]> books = new Dictionary<string, string[]>(); //All book dataset

//  Methods
//  Adding a book to the Dictionary
    public void AddBook(Book book)
    {
        if (books.ContainsKey(book.getTitle()))   //non-console check
        {
            Console.WriteLine("Book already exists");
        }
        else if(int.TryParse(book.getPublishYear(), out int year) == false)  //checking if the year containst only numbers
        {
            Console.WriteLine("Wrong format for year, only numbers are allowed");
        }
        else
        {
            books.Add(book.getTitle(), new string[] { book.getAuthor(), book.getPublishYear() });
            Console.WriteLine("Book added");
        }
    }
//  Show all books, notify if the Dictionary is empty
    public void ShowAllBooks()
    {
        if (books.Count == 0)
        {
            Console.WriteLine("There are no books");
        }
        
        else
        {
            foreach (var book in books)  //iterating over Dictionary
            {
            Console.WriteLine($"Name: {book.Key}, Author: {book.Value[0]}, Year Published: {book.Value[1]}"); 
            }
        }    
    }

//  Show full information about a book/check method through console
    public void SearchByTitle(string title)
    {
        if (books.ContainsKey(title))
        {
            Console.WriteLine($"Name: {title}, Author: {books[title][0]}, Year Published: {books[title][1]}");
        }
        else
        {
            throw new BookRelatedException("Book not found, if you want to add a new book, use the add feature"); //throw exception if book does not exist in the Dictionary
        }

    }

//  Remove book from the Dictionary
    public void RemoveBookByTitle(string title)
    {
            if (books.ContainsKey(title))
        {
            books.Remove(title);
            Console.WriteLine("Book removed");
        }
        else
        {
            Console.WriteLine("Book not found, nothing was removed");
        }
        
    }

//  Update book information in the Dictionary
    public void UpdateBookByTitle(string title, string author, string publishYear)
    {
        if (books.ContainsKey(title)) //non-console check
        {
            if(int.TryParse(publishYear, out int year) == false) //checking if the year containst only numbers
            {
                Console.WriteLine("Wrong format for year, book was not updated");
            }
            else
            {
                books[title] = new string[] { author, publishYear };
                Console.WriteLine("Book updated");
            }            
        }
        else
        {
            Console.WriteLine("Book with this title not found");
        }
    }

//  check method through console
    public void ContainsTitle(string title)
    {
        if (books.ContainsKey(title))
        {
            Console.WriteLine($"Name: {title}, Author: {books[title][0]}, Year Published: {books[title][1]}");
            throw new BookRelatedException("Book already exists, if you want to update it, please use the update feature");  //throw exception if book is already in the Dictionary
        }
    }
}