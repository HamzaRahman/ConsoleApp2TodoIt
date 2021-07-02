using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2TodoIt.Model
{
    class Person
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
    }
}
