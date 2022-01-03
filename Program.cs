using System;

namespace A4_MerrittRyan
{
    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();


            Console.WriteLine("-------Testing Library.AddNewBook()-------------\n");
            Console.WriteLine("Add Book Learning C# by Liberty, Edition: 2 ");
            library.AddNewBook("Learning C#", "Liberty", 2);
            Console.WriteLine("Add Book Introduction to C# by Deitel, Edition: 1 ");
            library.AddNewBook("Introduction to C#", "Deitel", 1);
            Console.WriteLine("Add Book Harry Potter by Rowling ");
            library.AddNewBook("Harry Potter", "Rowling");
            Console.WriteLine("Add Book Advanced C# by Murach, Edition: 4 ");
            library.AddNewBook("Advanced C#", "Murach", 4);
            Console.WriteLine("Add Book The Odyssey by Homer ");
            library.AddNewBook("The Odyssey", "Homer");
            Console.WriteLine();

            Console.WriteLine("-------Testing Library.ToString()-------------\n");
            Console.WriteLine(library.ToString());
            Console.WriteLine();

            Console.WriteLine("Issuing Books...");
            Console.WriteLine("library.IssueBook(101): " + library.IssueBook(101));
            Console.WriteLine("library.IssueBook(103): " + library.IssueBook(103));
            Console.WriteLine("library.IssueBook(101): " + library.IssueBook(101));
            Console.WriteLine("library.IssueBook(105): " + library.IssueBook(105));
            Console.WriteLine("library.IssueBook(106): " + library.IssueBook(106));

            Console.WriteLine();
            Console.WriteLine(library.ToString());

            Console.WriteLine("Renewing Books...");
            Console.WriteLine("library.RenewBook(101): " + library.RenewBook(101));
            Console.WriteLine("library.RenewBook(101): " + library.RenewBook(101));
            Console.WriteLine("library.RenewBook(103): " + library.RenewBook(103));
            Console.WriteLine("library.ReturnBook(106): " + library.ReturnBook(106));
            Console.WriteLine();
            Console.WriteLine(library.ToString());

            Console.WriteLine("Returning Books...");
            Console.WriteLine("library.ReturnBook(101): " + library.ReturnBook(101));
            Console.WriteLine("library.ReturnBook(103): " + library.ReturnBook(103));
            Console.WriteLine("library.ReturnBook(103): " + library.ReturnBook(103));
            Console.WriteLine("library.ReturnBook(102): " + library.ReturnBook(102));
            Console.WriteLine("library.ReturnBook(106): " + library.ReturnBook(106));
            Console.WriteLine();


            Console.WriteLine(library.ToString());
        }
    }
}
