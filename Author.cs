using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace library_management_csharp {
    public class Author(string name, string biography) {
        public string Name { get; private set; } = name;
        public string Biography { get; private set; } = biography;

        public void DisplayAuthorInfo() {
            Console.WriteLine($"Author: {Name}");
            Console.WriteLine($"Biography: {Biography}\n");
        }
    }
}