using ConsoleApp2TodoIt.Data;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ConsoleApp2TodoIt.UnitTests
{
    public class PersonSequencer_UnitTest
    {
        [Fact]
        public void PersonIDTest()
        {
            //First we reset the preson id because it is called some else places in the code too
            //and may be still increased and we won't know how much is it, so we simply reset it to zero
            //and increase by one again and test if its one
            PersonSequencer.reset();
            int ID = PersonSequencer.nextPersonid();
            Assert.Equal(1, ID);
        }
        [Fact]
        public void ResetTest()
        {
            PersonSequencer.reset();
        }
    }
}
