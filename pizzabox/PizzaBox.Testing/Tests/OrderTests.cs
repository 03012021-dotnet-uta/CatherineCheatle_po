using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models;
using Xunit;

namespace PizzaBox.Testing.Tests
{
    public class OrderTests
    { 
        [Fact]
        public void Test_Order_Fact()
        {
            // Arrange
            List<APizza> myPizzas = new List<APizza>();
            myPizzas.Add(new CheesePizza());
            Customer cust = new Customer("John Smith", "jsmith@gmail.com");
            NewYorkStore store = new NewYorkStore();

            var myOrder = new Order(myPizzas, store.Name, cust);

            var expectedStore = "New York Store";
            var expectedCustomer = cust;
            var expectedPizza = myPizzas;

            //act
            var actualStore = myOrder.StoreName;
            var actualCustomer = myOrder.Cust;
            var actualPizza = myOrder.Pizzas;

            //Assert
            Assert.Equal(expectedStore, actualStore);
            Assert.Equal(expectedCustomer, actualCustomer);
            Assert.Equal(expectedPizza, actualPizza);
        }

        [Fact]
        public void Test_Customer_Fact()
        {
            //Arrange
            Customer cust = new Customer("John Smith", "jsmith@email.com");

            var nameExpected = "John Smith";
            var emailExpected = "jsmith@email.com";

            //act
            var nameActual = cust.Name;
            var emailActual = cust.Email;

            //Assert
            Assert.Equal(nameExpected, nameActual);
            Assert.Equal(emailExpected, emailActual);
        }

        
    }
}