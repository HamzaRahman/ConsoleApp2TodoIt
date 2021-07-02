using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2TodoIt.Data
{
    public class PersonSequencer
    {
        //Task 6 a
        static int personId;
        //Task 6 b
        public static int nextPersonid()
        {
            return personId = personId + 1;
        }
    }
}
