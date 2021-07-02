using ConsoleApp2TodoIt.Data;
using ConsoleApp2TodoIt.Model;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ConsoleApp2TodoIt.UnitTests
{
    public class TodoItems_UnitTest
    {
        TodoItems todoItems = new TodoItems();
        //Task 9 b
        [Fact]
        public void SizeTest()
        {
            int i = 0;
            int ps = todoItems.Size();
            Assert.Equal(i.GetType(), ps.GetType());
        }
        //Task 9 c
        [Fact]
        public void FindAllTest()
        {
            Todo[] peoples = new Todo[0];
            Todo[] ps = todoItems.FindAll();
            Assert.Equal(peoples.GetType(), ps.GetType());
        }
        //Task 9 d
        [Theory]
        [InlineData(1)]
        public void FindByIDTest(int ID)
        {
            Person pr = new Person(1, "dd", "ee");
            //To test find by ID, we first store a todo item
            todoItems.AddTodo("mm", true, pr);
            //Then we test to find it by giving its ID
            Todo ps = todoItems.FindByID(ID);
            Assert.Equal(1, ps.todoID);
        }
        //Task 9 e
        [Theory]
        [InlineData("Todo 1")]
        public void AddTest(string Desc)
        {
            Person pr = new Person(1, "dd", "ee");
            Todo ps = todoItems.AddTodo(Desc, true, pr);
            Assert.Equal(1, ps.todoID);
        }


    }
}
