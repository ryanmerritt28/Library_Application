using System;
using System.Collections.Generic;
using System.Text;

namespace A4_MerrittRyan
{
    class TextBook : Book, IRenewable
    {
        //private attributes for TextBook
        private int edition;

        //Constructor for TextBook referencing base class for title and authors
        public TextBook(string title, string authors, int edition) : base(title, authors)
        {
            this.edition = edition;
        }

        //Returns a string containing TextBook information
        public override string ToString()
        {
            string tbook = "";
            string formatStr = "{0, -20}";
            tbook = base.ToString() + String.Format(formatStr, "Edition: " + edition);
            return tbook;
        }

        //public method setting due date to 30 days after checkout
        public override DateTime FindDueDate()
        {
            DateTime textDueDate = DateTime.Now;
            dueDate = textDueDate.AddDays(30);
            return dueDate;
        }

        //renews textbook by adding 15 days to due date
        public bool Renew()
        {
            if (!checkedOut)
            {
                return false;
            }

            DateTime origDueDate = FindDueDate();
            dueDate = origDueDate.AddDays(15);
            return true;
        }
    }
}
