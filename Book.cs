using System;
using System.Collections.Generic;
using System.Text;

namespace A4_MerrittRyan
{
    abstract class Book
    {
        //private attributes
        private int catalogNumber;
        private string title;
        private string authors;
        private static int nextCatalogNumber = 101;
        protected bool checkedOut;
        protected DateTime dueDate = DateTime.Now;


        //read-only property for catalogNumber
        public int CatalogNumber
        {
            get { return catalogNumber; }
        }

        //constructor taking title and authors as parameters
        public Book(string title, string authors)
        {
            this.title = title;
            this.authors = authors;
            NewCatNumber();
        }

        //default constructor
        public Book()
        {
            NewCatNumber();
        }

        //public method for converting book info to string
        public virtual string ToString()
        {
            string formatStr = "{0, -6}{1, -20}{2, -20}{3,-40}";
            string dueDateString = "Due on " + dueDate;
            if (!checkedOut)
            {
                dueDateString = "Available";
            }
            string row = String.Format(formatStr, catalogNumber, title, authors, dueDateString);
            return row;
        }

        //public method to calculate and return the due date of a book
        public abstract DateTime FindDueDate();


        //public method to determine checkout status
        public bool CheckOut()
        {
            if (!checkedOut)
            {
                checkedOut = true;
                FindDueDate();
                return true;
            }
            return false;
        }

        //public method to determine checkin status
        public bool CheckIn()
        {
            if (checkedOut)
            {
                checkedOut = false;
                return true;
            }
            return false;
        }

        //private method for generating and assigning unique catalog number
        private int NewCatNumber()
        {
            this.catalogNumber = nextCatalogNumber;
            nextCatalogNumber++;
            return catalogNumber;
        }
    }
}
