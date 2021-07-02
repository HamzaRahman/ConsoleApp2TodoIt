using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2TodoIt.Model
{
    //Public 
    public class Person
    {
        //Task 3a
        readonly int personId;
        string firstName;
        string lastName;
        //Task 3b
        public Person(int pID, string firstName, string lastName)
        {
            //Initializing/creating object.
            this.personId = pID;
            this.firstName = firstName;
            this.lastName = lastName;
        }
        public int PersonID
        {
            get
            {
                return personId;
            }
        }

        //Task 3c
        public string FirstName
        {
            get { return firstName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Empty or only whitespace is not allowed.");
                }

                firstName = value;
            }
        }
        public string LastName
        {
            get { return lastName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Empty or only whitespace is not allowed.");
                }

                lastName = value;
            }
        }
    }
}
