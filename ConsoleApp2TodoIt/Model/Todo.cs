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
    }
}
