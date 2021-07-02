using ConsoleApp2TodoIt.Data;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ConsoleApp2TodoIt.UnitTests
{
    public class TodoSequencer_UnitTest
    {
        [Fact]
        public void TodoIDTest()
        {
            int ID = TodoSequencer.nextTodoid();
            Assert.Equal(1, ID);
        }
        [Fact]
        public void ResetTest()
        {
            TodoSequencer.reset();
        }
    }
}
