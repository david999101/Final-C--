class Program 
{
    static void Main(string[] args)
    {
        BookManager bm = new BookManager();
        // // Interact without Console:
        // Book book1 = new Book("Harry Potter", "J.K. Rowling", "1997");
        // Book book2 = new Book("To Kill a Mockingbird", "Harper Lee", "1960");
        // Book book3 = new Book("The Great Gatsby", "F. Scott Fitzgerald", "1925");
        // bm.AddBook(book1);
        // Console.WriteLine(book1);
        // bm.AddBook(book2);
        // bm.AddBook(book3);
        // bm.AddBook(new Book("Harry Potter", "jgjhg", "2000"));
        // bm.AddBook(new Book("whatever", "jgjhg", "fdsgds"));
        // bm.UpdateBookByTitle("Harry Potter", "jgjhg", "dasdsa");
        // bm.RemoveBookByTitle("To Kill a Mockingbird");
        // bm.RemoveBookByTitle("To Kill a Mockingbird");
        // bm.UpdateBookByTitle("dsadsad", "dsadasd", "dsadsa"); 

//      Console interaction - 6 possible options
        while (true)
        {
            Console.WriteLine("Enter one of the options: 1 - Add Book, 2 - Show All Books, 3 - Search By Title, 4 - Remove Book By Title, 5 - Update Book By Title, 6 - Exit");
            Console.Write("Enter your option: ");

            try{   //check if entered string is a number between 1 and 6
            switch (NumberOutOfRangeException.ValidateNumber(Console.ReadLine()))
            {
                case 1:     
                    Console.Write("Enter title: ");
                    string title = Console.ReadLine();
                        try
                        {
                            bm.ContainsTitle(title); //immediate check
                        }
                        catch (BookRelatedException e)
                        {
                            Console.WriteLine(e.Message);
                            break;
                        }
                    Console.Write("Enter author: ");
                    string author = Console.ReadLine();
                    Console.Write("Enter publish year: ");
                    string publishYear = Console.ReadLine();
                    bm.AddBook(new Book(title, author, publishYear));
                    break;
                case 2:
                    bm.ShowAllBooks();
                    break;
                case 3:
                    Console.Write("Enter Title: ");
                    try
                    {
                        bm.SearchByTitle(Console.ReadLine());  //immediate check
                        break;
                    }
                    catch (BookRelatedException e)
                    {
                        Console.WriteLine(e.Message);
                        break;
                    }
                case 4:
                    Console.Write("Enter title: ");
                    bm.RemoveBookByTitle(Console.ReadLine());
                    break;
                case 5:
                    Console.Write("Enter title of the book to change: ");
                    string title2 = Console.ReadLine();
                    try
                    {
                        bm.SearchByTitle(title2);  //immediate check
                    }
                    catch (BookRelatedException e)
                    {
                        Console.WriteLine(e.Message);
                        break;
                    }
                    Console.Write("Enter new author: ");
                    string author2 = Console.ReadLine();
                    Console.Write("Enter publish year: ");
                    string publishYear2 = Console.ReadLine();
                    bm.UpdateBookByTitle(title2, author2, publishYear2);
                    break;
                case 6:
                    return;            
            }
            }
            catch (NumberOutOfRangeException)
            {
                Console.WriteLine("Enter a number from 1 to 6, please");
            }
        }
    }
}