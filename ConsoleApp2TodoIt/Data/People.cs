using ConsoleApp2TodoIt.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2TodoIt.Data
{
    public class People
    {
        //Task 8 a
        static Person[] peoples = new Person[0];
        //Task 8 b
        public int Size()
        {
            return peoples.Length;
        }
        //Task 8 c
        public Person[] FindAll()
        {
            return peoples;
        }
        //Task 8 d
        public Person FindByID(int PersonID)
        {
            //We are taking this person because we have to return something at the end if our wanted person is not found
            //To know whether the function returned the person we wanted or this new one, we are setting its ID to 0
            //Because all other persons ID will start form one and we will know if its zero than not found, else if its greater than
            //zero, its found
            Person person = new Person(0, "MM", "MM");
            //Here we run a foreach loop on peoples array
            foreach (var p in peoples)
            {
                //Then we compare our wanted ID with every persons ID
                if (p.PersonID == PersonID)
                {
                    //if its found then it will be returned
                    return p;
                }
            }
            //else the 0 ID person we created will be returned
            return person;
        }
        //Task 8 e
        public Person AddPerson(string Fname, string Lname)
        {
            int size = Size();
            size = size + 1;
            Array.Resize(ref peoples, size);
            int ID = PersonSequencer.nextPersonid();
            Person person = new Person(ID, Fname, Lname);
            peoples[size - 1] = person;
            return person;
        }
    }
}
