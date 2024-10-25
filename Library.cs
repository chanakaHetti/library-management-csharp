using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace library_management_csharp {
    public class Library {
        private List<Book> books = new List<Book>();

        public void AddBook(Book book) {
            books.Add(book);
            Console.WriteLine($"Book '{book.Title}' added to the library.\n");
        }

        public void DisplayAllBooks() {
            Console.WriteLine("Library Books:");

            foreach (var book in books) {
                book.DisplayBookInfo();
            }
        }

        public Book? FindBookById(int id) {
            return books.Find(b => b.Id == id);
        }
    }
}