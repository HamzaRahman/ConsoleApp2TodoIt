using ConsoleApp2TodoIt.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2TodoIt.Data
{
    public class TodoItems
    {
        //Task 9 a
        static Todo[] todoitems = new Todo[0];
        //Task 9 b
        public int Size()
        {
            return todoitems.Length;
        }
        //Task 9 c
        public Todo[] FindAll()
        {
            return todoitems;
        }
        //Task 9 d
        public Todo FindByID(int todoid)
        {
            Todo todo = new Todo(0, "MM");
            foreach (var p in todoitems)
            {
                if (p.todoID == todoid)
                {
                    return p;
                }

            }
            return todo;
        }
    }
}
