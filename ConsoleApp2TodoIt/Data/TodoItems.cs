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
        //Task 9 e
        public Todo AddTodo(string Desc, bool status, Person pi)
        {
            int size = Size();
            size = size + 1;
            Array.Resize<Todo>(ref todoitems, size);
            int ID = TodoSequencer.nextTodoid();
            Todo p = new Todo(ID, Desc);
            p.Done = status;
            p.Assignee = pi;
            todoitems[size - 1] = p;
            return p;
        }
        //Task 9 f
        public void Clear()
        {
            todoitems = new Todo[0];
        }
        //Task 10 a
        public Todo[] FindByDoneStatus(bool doneStatus)
        {
            //here we take new size variable for a new Todo array
            //in which the matching done status items will  be stored
            int size = 0;
            Todo[] ti = new Todo[0];
            foreach (var t in todoitems)
            {
                if (t.Done == doneStatus)
                {
                    size = size + 1;
                    Array.Resize<Todo>(ref ti, size);
                    ti[size - 1] = t;
                }
            }
            return ti;
        }
        //Task 10 b
        public Todo[] FindByAssignee(int personid)
        {
            int size = 0;
            Todo[] ti = new Todo[0];
            foreach (var t in todoitems)
            {
                if (t.Assignee.PersonID == personid)
                {
                    size = size + 1;
                    Array.Resize<Todo>(ref ti, size);
                    ti[size - 1] = t;
                }
            }
            return ti;
        }
    }
}
