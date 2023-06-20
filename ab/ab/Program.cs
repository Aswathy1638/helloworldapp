using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class Program
    {
        private static List<Book> books = new List<Book>();
        private static List<Author> authors = new List<Author>();
        private static List<Borrower> borrowers = new List<Borrower>();
        private static List<BorrowedBook> borrowedBooks = new List<BorrowedBook>();

        static void Main(string[] args)
        {
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("===== Library Management System =====");
                Console.WriteLine("1. Add a Book");
                Console.WriteLine("2. Update a Book");
                Console.WriteLine("3. Delete a Book");
                Console.WriteLine("4. Add an Author");
                Console.WriteLine("5. Update an Author");
                Console.WriteLine("6. Delete an Author");
                Console.WriteLine("7. Add a Borrower");
                Console.WriteLine("8. Update a Borrower");
                Console.WriteLine("9. Delete a Borrower");
                Console.WriteLine("10. Register a Book to a Borrower");
                Console.WriteLine("11. Display All Books");
                Console.WriteLine("12. Display All Authors");
                Console.WriteLine("13. Display All Borrowers");
                Console.WriteLine("14. Search for a Book");
                Console.WriteLine("15. Exit");

                Console.WriteLine("\nEnter your choice (1-15):");
                int choice = Convert.ToInt32(Console.ReadLine());

                Console.Clear();

                switch (choice)
                {
                    case 1:
                        AddBook();
                        break;
                    case 2:
                        UpdateBook();
                        break;
                    case 3:
                        DeleteBook();
                        break;
                    case 4:
                        AddAuthor();
                        break;
                    case 5:
                        UpdateAuthor();
                        break;
                    case 6:
                        DeleteAuthor();
                        break;
                    case 7:
                        AddBorrower();
                        break;
                    case 8:
                        UpdateBorrower();
                        break;
                    case 9:
                        DeleteBorrower();
                        break;
                    case 10:
                        RegisterBookToBorrower();
                        break;
                    case 11:
                        DisplayAllBooks();
                        break;
                    case 12:
                        DisplayAllAuthors();
                        break;
                    case 13:
                        DisplayAllBorrowers();
                        break;
                    case 14:
                        SearchBook();
                        break;
                    case 15:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }

        private static void AddBook()
        {
            Console.WriteLine("===== Add a Book =====");
            Console.WriteLine("Enter the book title:");
            string title = Console.ReadLine();

            Console.WriteLine("Enter the book author:");
            string author = Console.ReadLine();

            Console.WriteLine("Enter the publication year:");
            int publicationYear = Convert.ToInt32(Console.ReadLine());

            Book book = new Book(title, author, publicationYear);
            books.Add(book);

            Console.WriteLine("\nBook added successfully!");
        }

        private static void UpdateBook()
        {
            Console.WriteLine("===== Update a Book =====");
            Console.WriteLine("Enter the book title:");
            string title = Console.ReadLine();

            Book book = books.FirstOrDefault(b => b.Title == title);

            if (book != null)
            {
                Console.WriteLine("Enter the new book title:");
                string newTitle = Console.ReadLine();

                Console.WriteLine("Enter the new book author:");
                string newAuthor = Console.ReadLine();

                Console.WriteLine("Enter the new publication year:");
                int newPublicationYear = Convert.ToInt32(Console.ReadLine());

                book.Title = newTitle;
                book.Author = newAuthor;
                book.PublicationYear = newPublicationYear;

                Console.WriteLine("\nBook updated successfully!");
            }
            else
            {
                Console.WriteLine("Book not found.");
            }
        }

        private static void DeleteBook()
        {
            Console.WriteLine("===== Delete a Book =====");
            Console.WriteLine("Enter the book title:");
            string title = Console.ReadLine();

            Book book = books.FirstOrDefault(b => b.Title == title);

            if (book != null)
            {
                books.Remove(book);
                Console.WriteLine("\nBook deleted successfully!");
            }
            else
            {
                Console.WriteLine("Book not found.");
            }
        }

        private static void AddAuthor()
        {
            Console.WriteLine("===== Add an Author =====");
            Console.WriteLine("Enter the author's first name:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter the author's last name:");
            string lastName = Console.ReadLine();

            Console.WriteLine("Enter the author's date of birth (YYYY-MM-DD):");
            DateTime dateOfBirth = Convert.ToDateTime(Console.ReadLine());

            Author author = new Author(firstName, lastName, dateOfBirth);
            authors.Add(author);

            Console.WriteLine("\nAuthor added successfully!");
        }

        private static void UpdateAuthor()
        {
            Console.WriteLine("===== Update an Author =====");
            Console.WriteLine("Enter the author's first name:");
            string firstName = Console.ReadLine();

            Author author = authors.FirstOrDefault(a => a.FirstName == firstName);

            if (author != null)
            {
                Console.WriteLine("Enter the new author's first name:");
                string newFirstName = Console.ReadLine();

                Console.WriteLine("Enter the new author's last name:");
                string newLastName = Console.ReadLine();

                Console.WriteLine("Enter the new author's date of birth (YYYY-MM-DD):");
                DateTime newDateOfBirth = Convert.ToDateTime(Console.ReadLine());

                author.FirstName = newFirstName;
                author.LastName = newLastName;
                author.DateOfBirth = newDateOfBirth;

                Console.WriteLine("\nAuthor updated successfully!");
            }
            else
            {
                Console.WriteLine("Author not found.");
            }
        }

        private static void DeleteAuthor()
        {
            Console.WriteLine("===== Delete an Author =====");
            Console.WriteLine("Enter the author's first name:");
            string firstName = Console.ReadLine();

            Author author = authors.FirstOrDefault(a => a.FirstName == firstName);

            if (author != null)
            {
                authors.Remove(author);
                Console.WriteLine("\nAuthor deleted successfully!");
            }
            else
            {
                Console.WriteLine("Author not found.");
            }
        }

        private static void AddBorrower()
        {
            Console.WriteLine("===== Add a Borrower =====");
            Console.WriteLine("Enter the borrower's first name:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter the borrower's last name:");
            string lastName = Console.ReadLine();

            Console.WriteLine("Enter the borrower's email:");
            string email = Console.ReadLine();

            Console.WriteLine("Enter the borrower's phone number:");
            string phoneNumber = Console.ReadLine();

            Borrower borrower = new Borrower(firstName, lastName, email, phoneNumber);
            borrowers.Add(borrower);

            Console.WriteLine("\nBorrower added successfully!");
        }

        private static void UpdateBorrower()
        {
            Console.WriteLine("===== Update a Borrower =====");
            Console.WriteLine("Enter the borrower's first name:");
            string firstName = Console.ReadLine();

            Borrower borrower = borrowers.FirstOrDefault(b => b.FirstName == firstName);

            if (borrower != null)
            {
                Console.WriteLine("Enter the new borrower's first name:");
                string newFirstName = Console.ReadLine();

                Console.WriteLine("Enter the new borrower's last name:");
                string newLastName = Console.ReadLine();

                Console.WriteLine("Enter the new borrower's email:");
                string newEmail = Console.ReadLine();

                Console.WriteLine("Enter the new borrower's phone number:");
                string newPhoneNumber = Console.ReadLine();

                borrower.FirstName = newFirstName;
                borrower.LastName = newLastName;
                borrower.Email = newEmail;
                borrower.PhoneNumber = newPhoneNumber;

                Console.WriteLine("\nBorrower updated successfully!");
            }
            else
            {
                Console.WriteLine("Borrower not found.");
            }
        }

        private static void DeleteBorrower()
        {
            Console.WriteLine("===== Delete a Borrower =====");
            Console.WriteLine("Enter the borrower's first name:");
            string firstName = Console.ReadLine();

            Borrower borrower = borrowers.FirstOrDefault(b => b.FirstName == firstName);

            if (borrower != null)
            {
                borrowers.Remove(borrower);
                Console.WriteLine("\nBorrower deleted successfully!");
            }
            else
            {
                Console.WriteLine("Borrower not found.");
            }
        }

        private static void RegisterBookToBorrower()
        {
            Console.WriteLine("===== Register a Book to a Borrower =====");
            Console.WriteLine("Enter the book title:");
            string title = Console.ReadLine();

            Book book = books.FirstOrDefault(b => b.Title == title);

            if (book != null)
            {
                Console.WriteLine("Enter the borrower's first name:");
                string borrowerFirstName = Console.ReadLine();

                Borrower borrower = borrowers.FirstOrDefault(b => b.FirstName == borrowerFirstName);

                if (borrower != null)
                {
                    Console.WriteLine("Enter the borrow date (YYYY-MM-DD):");
                    DateTime borrowDate = Convert.ToDateTime(Console.ReadLine());

                    Console.WriteLine("Enter the due date (YYYY-MM-DD):");
                    DateTime dueDate = Convert.ToDateTime(Console.ReadLine());

                    BorrowedBook borrowedBook = new BorrowedBook(book, borrower, borrowDate, dueDate);
                    borrowedBooks.Add(borrowedBook);

                    Console.WriteLine("\nBook registered to borrower successfully!");
                }
                else
                {
                    Console.WriteLine("Borrower not found.");
                }
            }
            else
            {
                Console.WriteLine("Book not found.");
            }
        }

        private static void DisplayAllBooks()
        {
            Console.WriteLine("===== All Books =====");
            foreach (Book book in books)
            {
                Console.WriteLine(book);
            }
        }

        private static void DisplayAllAuthors()
        {
            Console.WriteLine("===== All Authors =====");
            foreach (Author author in authors)
            {
                Console.WriteLine(author);
            }
        }

        private static void DisplayAllBorrowers()
        {
            Console.WriteLine("===== All Borrowers =====");
            foreach (Borrower borrower in borrowers)
            {
                Console.WriteLine(borrower);
            }
        }

        private static void SearchBook()
        {
            Console.WriteLine("===== Search for a Book =====");
            Console.WriteLine("Enter the search keyword:");
            string keyword = Console.ReadLine();

            var searchResults = books.Where(b => b.Title.Contains(keyword)
                                                || b.Author.Contains(keyword)
                                                || borrowedBooks.Any(bb => bb.Book.Title.Contains(keyword) && bb.Book.Title == b.Title));

            Console.WriteLine("Search Results:");
            foreach (Book book in searchResults)
            {
                Console.WriteLine(book);
            }
        }
    }

    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int PublicationYear { get; set; }
        public bool IsAvailable { get; set; } = true;

        public Book(string title, string author, int publicationYear)
        {
            Title = title;
            Author = author;
            PublicationYear = publicationYear;
        }

        public override string ToString()
        {
            return $"Title: {Title}, Author: {Author}, Publication Year: {PublicationYear}, Availability: {(IsAvailable ? "Available" : "Borrowed")}";
        }
    }

    public class Author
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }

        public Author(string firstName, string lastName, DateTime dateOfBirth)  
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
        }

        public override string ToString()
        {
            return $"Name: {FirstName} {LastName}, Date of Birth: {DateOfBirth.ToShortDateString()}";
        }
    }

    public class Borrower
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public Borrower(string firstName, string lastName, string email, string phoneNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
        }

        public override string ToString()
        {
            return $"Name: {FirstName} {LastName}, Email: {Email}, Phone Number: {PhoneNumber}";
        }
    }

    public class BorrowedBook
    {
        public Book Book { get; set; }
        public Borrower Borrower { get; set; }
        public DateTime BorrowDate { get; set; }
        public DateTime DueDate { get; set; }

        public BorrowedBook(Book book, Borrower borrower, DateTime borrowDate, DateTime dueDate)
        {
            Book = book;
            Borrower = borrower;
            BorrowDate = borrowDate;
            DueDate = dueDate;
        }
    }
}
