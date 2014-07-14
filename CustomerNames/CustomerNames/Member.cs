/* Class:	Member.cs   
 * Name:	Rick Larsen
 * Date:	8/9/2013 
 * Purpose:	This class includes members for the field in the database and displays a
 *          formatted full name. 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomerNames
{
    public class Member
    {
        private string custNumber;
        private string firstName;
        private string lastName;
        private string area;

        // Constructor
        public Member()
        {
        }

        public Member(string fname, string lname)
        {
            firstName = fname;
            lastName = lname;
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
        }

        public string CustNumber
        {
            get
            {
                return custNumber;
            }
        }

        public string Area
        {
            get
            {
                return area;
            }
        }

        public override string ToString()
        {
            return firstName + " " + lastName;
        }
    }
}
