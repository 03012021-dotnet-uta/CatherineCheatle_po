using PizzaBox.Domain.Models;
using Xunit;

namespace PizzaBox.Testing.Tests
{
    public class StoreTests
    {
        [Fact]
        public void Test_ChicagoStore_Fact()
        {
            // arrange
            var sut = new ChicagoStore();
            var expected = "Chicago Store";

            // act 
            var actual = sut.Name;

            // assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void Test_NewYorkStore_Fact()
        {
            //Arrange
            var sut = new NewYorkStore();
            var expected = "New York Store";

            //act
            var actual = sut.Name;

            //Assert
            Assert.Equal(expected, actual);
        }


    }
}