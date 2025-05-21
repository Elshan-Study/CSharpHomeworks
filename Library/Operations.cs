namespace Library;

public static class LibrarySystem
    {
        static Book[] books =
        {
            new Book("1984", "George Orwell", Genre.Fiction),
            new Book("A Brief History of Time", "Stephen Hawking", Genre.Science),
            new Book("The Hobbit", "J.R.R. Tolkien", Genre.Fantasy)
        };

        static Member[] members =
        {
            new Member("Alice", 1),
            new Member("Bob", 2)
        };

        public static void Run()
        {
            while (true)
            {
                Console.WriteLine("\nLibrary Menu:");
                Console.WriteLine("1 - View Books");
                Console.WriteLine("2 - Borrow Book");
                Console.WriteLine("3 - Return Book");
                Console.WriteLine("4 - View Members");
                Console.WriteLine("0 - Exit");
                Console.Write("Choice: ");
                string? choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        ShowBooks();
                        break;
                    case "2":
                        BorrowBook();
                        break;
                    case "3":
                        ReturnBook();
                        break;
                    case "4":
                        ShowMembers();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
            }
        }

        private static void ShowBooks()
        {
            Console.WriteLine("\nBooks in Library:");
            for (int i = 0; i < books.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {books[i]}");
            }
        }

        private static void ShowMembers()
        {
            Console.WriteLine("\nLibrary Members:");
            foreach (var member in members)
            {
                Console.WriteLine(member);
            }
        }

        private static void BorrowBook()
        {
            ShowBooks();
            Console.Write("Enter book number to borrow: ");
            if (int.TryParse(Console.ReadLine(), out int bookIndex) && bookIndex > 0 && bookIndex <= books.Length)
            {
                Book book = books[bookIndex - 1];
                if (book.IsAvailable)
                {
                    book.IsAvailable = false;
                    Console.WriteLine($"You borrowed \"{book.Title}\".");
                }
                else
                {
                    Console.WriteLine("Book is already borrowed.");
                }
            }
            else
            {
                Console.WriteLine("Invalid book number.");
            }
        }

        private static void ReturnBook()
        {
            ShowBooks();
            Console.Write("Enter book number to return: ");
            if (int.TryParse(Console.ReadLine(), out int bookIndex) && bookIndex > 0 && bookIndex <= books.Length)
            {
                Book book = books[bookIndex - 1];
                if (!book.IsAvailable)
                {
                    book.IsAvailable = true;
                    Console.WriteLine($"You returned \"{book.Title}\".");
                }
                else
                {
                    Console.WriteLine("Book was not borrowed.");
                }
            }
            else
            {
                Console.WriteLine("Invalid book number.");
            }
        }
    }