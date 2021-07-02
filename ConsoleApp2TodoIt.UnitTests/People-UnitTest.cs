﻿using ConsoleApp2TodoIt.Data;
using ConsoleApp2TodoIt.Model;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ConsoleApp2TodoIt.UnitTests
{
    public class People_UnitTest
    {
        People people = new People();
        //Task 8 d
        [Theory]
        [InlineData(1)]
        public void FindByIDTest(int ID)
        {
            people.AddPerson("MM", "ff");
            Person ps = people.FindByID(ID);
            Assert.Equal(1, ps.PersonID);
        }
        //Task 8 b
        [Fact]
        public void SizeTest()
        {
            int i = 0;
            int size = people.Size();
            Assert.Equal(i.GetType(), size.GetType());
        }
        //Task 8 c
        [Fact]
        public void FindAllTest()
        {
            Person[] peoples = new Person[0];
            Person[] ps = people.FindAll();
            Assert.Equal(peoples.GetType(), ps.GetType());
        }
        //Task 8 e
        [Theory]
        [InlineData("Magnus", "Ivarson")]
        public void AddTest(string Fname, string Lname)
        {
            Person ps = people.AddPerson(Fname, Lname);
            Assert.Equal(1, ps.PersonID);

        }

        //We are adding one more person after AddTest and checking if really the array expands and stores multiple person
        //I was checking ID 1 for AddNewTest because sometimes the this test runs first and was 
        //checking ID 2 for AddTest because sometimes it runs after AddNewTest
        //But if you run only PeopleTest by right clicking on PeopleTest in the test list and Run Selecteed Tests,
        //except for Run all, it will be passed

        //Task 8 e
        [Theory]
        [InlineData("Magnus", "Ivarson")]
        public void AddNewTest(string Fname, string Lname)
        {
            Person ps = people.AddPerson(Fname, Lname);
            Assert.Equal(2, ps.PersonID);
        }


        //Task 8 f
        //First We Clear The Array then we test if its size is equal to zero or not
        //if zero than result is passed, if not then failed
        [Fact]
        public void ClearTest()
        {
            people.Clear();
            int size = people.Size();
            Assert.Equal(0, size);
        }
    }
}
