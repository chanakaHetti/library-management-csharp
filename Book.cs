using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace library_management_csharp {
    public class Book(int id, string title, Author author) {
        public int Id { get; private set; } = id;
        public string Title { get; private set; } = title;
        public Author BookAuthor { get; private set; } = author;
        public bool IsAvailable { get; private set; } = true;

        public void DisplayBookInfo() {
            Console.WriteLine($"Book ID: {Id}");
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {BookAuthor.Name}");
            Console.WriteLine($"Availability: {(IsAvailable ? "Available" : "Checked out")}\n");
        }

        public void ToggleAvailability() {
            IsAvailable = !IsAvailable;
        }
    }
}