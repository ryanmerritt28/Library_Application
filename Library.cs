using System;
using System.Collections.Generic;
using System.Text;

namespace A4_MerrittRyan
{
    class Library
    {
        //private attributes
        private List<Book> booksList = new List<Book>();

        //public method for adding new GeneralBook
        public void AddNewBook(string bookTitle, string bookAuthor)
        {
            Book b = new GeneralBook(bookTitle, bookAuthor);
            booksList.Add(b);
        }

        //public method for adding new TextBook
        public void AddNewBook(string bTitle, string bAuthor, int edition)
        {
            Book t = new TextBook(bTitle, bAuthor, edition);
            booksList.Add(t);
        }

        //public method for remove a book
        public bool RemoveBook(int catalogNumber)
        {
            for (int i = 0; i < booksList.Count; i++)
            {
                if (booksList[i].CatalogNumber == catalogNumber)
                {
                    booksList.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }

        //public method for searching for a book
        public string SearchBook(int catalogNumber)
        {
            for (int i = 0; i < booksList.Count; i++)
            {
                if (booksList[i].CatalogNumber == catalogNumber)
                {
                    return booksList[i].ToString();
                }
            }
            return "Not Found";
        }

        //public method for converting all book information to a string using ToString() from Book class
        public override string ToString()
        {
            string allBooks = "";
            for (int i = 0; i < booksList.Count; i++)
            {
                if (booksList[i] != null)
                {
                    allBooks += booksList[i].ToString() + "\n";
                }
            }
            return allBooks;
        }

        //returns string containing only TextBooks and their information
        public string GetAllTextBooksInformation()
        {
            string tb = "";
            for (int i = 0; i < booksList.Count; i++)
            {
                if (booksList[i] is TextBook)
                {
                    tb += booksList[i].ToString() + "\n";
                }
            }
            return tb;
        }

        //checks out book with given catalognumber
        public bool IssueBook(int bookCatalogNum)
        {

            for (int i = 0; i < booksList.Count; i++)
            {
                if (bookCatalogNum == booksList[i].CatalogNumber && booksList[i].CheckOut() == true)
                {
                    booksList[i].CheckOut();
                    return true;
                }
            }
            return false;
        }

        //checks in book with given catalognumber
        public bool ReturnBook(int bookCatalogNum)
        {
            for (int i = 0; i < booksList.Count; i++)
            {
                if (bookCatalogNum == booksList[i].CatalogNumber && booksList[i].CheckIn() == true)
                {
                    booksList[i].CheckIn();
                    return true;
                }
            }
            return false;
        }

        //renews book with given catalognumber
        public bool RenewBook(int bookCatalogNum)
        {
            for (int i = 0; i < booksList.Count; i++)
            {
                if (booksList[i] is TextBook && booksList[i].CatalogNumber == bookCatalogNum)
                {
                    return ((IRenewable)booksList[i]).Renew();

                }
            }
            return false;
        }
    }
}
