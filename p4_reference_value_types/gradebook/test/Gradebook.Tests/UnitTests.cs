using System;
using Xunit;

namespace Gradebook.Tests
{
    public class UnitTests
    {
        [Fact]
        public void BookCalculatesStats()
        {
            //arrange
            var book = new Book("");
            book.AddGrade(90.5);
            book.AddGrade(89.1);
            book.AddGrade(77.3);

            //act
            var result = book.ShowStatistics();

            //assert
            Assert.Equal(77.3, result.Low); 
            Assert.Equal(90.5, result.High);
            Assert.Equal(85.6, result.Average, 1);
        }
    }
}
