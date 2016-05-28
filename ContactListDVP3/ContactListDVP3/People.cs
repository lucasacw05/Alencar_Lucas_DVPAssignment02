using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactListDVP3
{
    //This is the class that have all the infomation about the people
    public class People
    {
        string firstName;
        string lastName;
        string number;
        string emailAddress;

        int imageIndex;
        //Setters and getters for the first name
        public string FirstName
        {
            get
            {
                return firstName;
            }

            set
            {
                firstName = value;
            }
        }

        //Setters and getters for the last name
        public string LastName
        {
            get
            {
                return lastName;
            }

            set
            {
                lastName = value;
            }
        }

        //Setters and getters for the number
        public string Number
        {
            get
            {
                return number;
            }

            set
            {
                number = value;
            }
        }
        //Setters and getters for the email name
        public string EmailAddress
        {
            get
            {
                return emailAddress;
            }

            set
            {
                emailAddress = value;
            }
        }

        //Setters and getters for the image 
        public int ImageIndex
        {
            get
            {
                return imageIndex;
            }

            set
            {
                imageIndex = value;
            }
        }

        //Returns all the information
        public override string ToString()
        {
            return LastName + "" + FirstName + "\n" + Number + "\n" + EmailAddress;
        }
    }
}
