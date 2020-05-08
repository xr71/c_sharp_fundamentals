using System;
using Xunit;

namespace Gradebook.Tests
{
    public class BookTest
    {
        [Fact]
        public void Test1()
        {
            // unit tests have 3 sections, arrange, act, assert

            // arrange
            var x = 5;
            var y = 2;
            var expected = 7;

            // act
            var actual = x + y;

            // assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test2()
        {
            // here we don't need the using statement because we are already under
            // the Gradebook namespace with our Gradebook.Tests namespace
            var book = new Book("");
            book.addGrade(89.1);
            book.addGrade(90.5);
            book.addGrade(77.3);

            // act
            var result = book.GetStatistics();

            // assert
            Assert.Equal(77.3, result.Low);
            Assert.Equal(90.5, result.High);
            Assert.Equal(85.6, result.Average, 1);

        }
    }
}
