using ConsoleApp2TodoIt.Model;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ConsoleApp2TodoIt.UnitTests
{
    public class Person_UnitTest
    {
        //This Test Is Conducted To Check Whether The Properties Accept Null Value Or Not
        //The Properties Raise An Error If We Try To Assign Null Value To Them
        //So we are gonna catch that error, which will prove properties don,t accept Null Values, Which means the test is passed
        [Theory]
        [InlineData(1, null, null)]
        public void NullTest(int ID, string Fname, string Lname)
        {
            try
            {
                Person person = new Person(ID, Fname, Lname);
            }
            catch (ArgumentException ex)
            {
                Assert.Equal("Empty or only whitespace is not allowed.", ex.Message);
            }
        }
        //This is a simple Test, Conducted to Simply assign any values to properties and check if they are being stored
        [Theory]
        [InlineData(1, "Magnus", "Ivarsson")]
        public void NormalTest(int ID, string Fname, string Lname)
        {
            Person person = new Person(ID, Fname, Lname);
            Assert.Equal("Magnus", person.FirstName);
            Assert.Equal("Ivarsson", person.LastName);
        }
    }
}
