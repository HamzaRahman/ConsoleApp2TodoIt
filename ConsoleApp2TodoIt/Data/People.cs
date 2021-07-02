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
    }
}
