using System;
using Xunit;

namespace Gradebook.Tests
{
    public class TypeTests
    {
        [Fact]
        public void Test1()
        {
            //arrange
            var book1 = GetBook("Book 1");
            var book2 = GetBook("Book 2");

            //act
            string expect_book1_name = "Book 1";
            string expect_book2_name = "Book 2";

            //assert
            Assert.Equal(expect_book1_name, book1.Name);

        }

        Book GetBook(string name) 
        {
            return new Book(name);
        }

        [Fact]
        public void TwoVarSameRef()
        {
            var book1 = GetBook("Book 1");
            var book2 = book1;

           Assert.Same(book1, book2); 

        }

        [Fact]
        public void CanSetNameFromRef() 
        {
            var book1 = GetBook("Book 1");
            SetName(book1, "New Name");

            Assert.Equal("New Name", book1.Name);
        }

        private void SetName(Book book, string name) 
        {
            book.Name = name;
        }

        [Fact]
        public void Test2() 
        {
            var book1 = GetBook("Book 1");
            GetBookSetName(book1, "New Name");

            // this will fail, a new copy of book is created
            Assert.Equal("New Name", book1.Name);
            // csharp by default is pass by value
            // a copy is made when we pass in a parameter
            // to modify directly, we need to pass in a pointer

        }

        private void GetBookSetName(Book book, string name) 
        {
            book = new Book(name);
        }


        [Fact]
        public void Test3()
        {
            var book1 = GetBook("Book 1");
            GetBookSetNameRef(ref book1, "New Name");

            // assert
            Assert.Equal("New Name", book1.Name);
        }

        private void GetBookSetNameRef(ref Book book, string name)
        {
            book = new Book(name);
        }


        [Fact]
        public void Test4()
        {
            var x = GetInt();

            Assert.Equal(3, x);
        }

        private int GetInt()
        {
            return 3;
        }


        [Fact]
        public void Test5()
        {
            var x = GetInt();
            // x is now 3
            SetInt(ref x);
            // to update the value of x, we need to pass in the ref, 
            // not just a copy of the value of x            

            // now x will be 42
            Assert.Equal(42, x);
        }

        private void SetInt(ref int x)
        {
            x = 42;
        }
    }
}
