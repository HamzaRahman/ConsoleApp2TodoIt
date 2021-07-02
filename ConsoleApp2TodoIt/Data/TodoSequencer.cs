using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2TodoIt.Data
{
    public class TodoSequencer
    {
        //Task 7 a.
        static int TodoId;
        //Task 7 b.
        public static int nextTodoid()
        {
            return TodoId = TodoId + 1;
        }
    }
}
