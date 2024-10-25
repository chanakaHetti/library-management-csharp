
namespace library_management_csharp {
    class Program {
        static void Main(string[] args) {
            // Create authors
            Author author1 = new("George Orwell", "English novelist and essayist, known for '1984' and 'Animal Farm'");
            Author author2 = new("Harper Lee", "Author of 'To Kill a Mockingbird'");

            // Create books
            Book book1 = new Book(1, "1984", author1);
            Book book2 = new Book(2, "Animal Farm", author1);
            Book book3 = new Book(3, "To Kill a Mockingbird", author2);

            // Create library
            Library library = new();
            library.AddBook(book1);
            library.AddBook(book2);
            library.AddBook(book3);

            // Display all books in the library
            library.DisplayAllBooks();

            // Find a book and toggle availability
            var foundBook = library.FindBookById(2);
            if (foundBook != null) {
                Console.WriteLine($"Toggling availability of '{foundBook.Title}'\n");
                foundBook.ToggleAvailability();
            }

            // Display updated book list
            library.DisplayAllBooks();
        }
    }
}