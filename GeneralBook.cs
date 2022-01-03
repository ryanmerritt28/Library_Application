using System;
using System.Collections.Generic;
using System.Text;

namespace A4_MerrittRyan
{
    class GeneralBook : Book
    {
        //constructor for GeneralBook referencing base class
        public GeneralBook(string title, string authors) : base(title, authors)
        { }

        //public method for setting due date of general book to 7 days after checkout
        public override DateTime FindDueDate()
        {
            DateTime genBookDue = DateTime.Now;
            dueDate = genBookDue.AddDays(7);
            return dueDate;
        }
    }
}
