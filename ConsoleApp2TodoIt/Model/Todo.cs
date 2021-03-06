using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2TodoIt.Model
{
    public class Todo
    {
        //Task 4 a
        readonly int todoid;
        string description;
        bool done;
        Person assignee;
        //Task 4 b
        public Todo(int todoid, string description)
        {
            this.todoid = todoid;
            this.description = description;
        }
        //-----------------------------------
        public int TodoID
        {
            get
            {
                return todoid;
            }
        }
        public bool Done
        {
            get
            {
                return done;
            }
            set
            {
                done = value;
            }
        }
        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
            }
        }
        public Person Assignee
        {
            get
            {
                return assignee;
            }
            set
            {
                assignee = value;
            }
        }
    }
}
