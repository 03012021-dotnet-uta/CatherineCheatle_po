using System.Collections.Generic;
using PizzaBox.Domain.Models;
using Xunit;

namespace PizzaBox.Testing.Tests
{
    public class PizzaTests
    {
        [Fact]
        public void Test_CheesePizza_Fact()
        {
            // arrange
            Crust pcrust = new Crust("Thin", 0.25);
            Size psize = new Size("Small", 5.99);
            var sut = new CheesePizza(pcrust, psize);
            
            var nameExpected = "Cheese Pizza";
            var sizeExpected = "Small";
            var sizePriceExpected = 5.99;
            var crustExpected = "Thin";
            var crustPriceExpeced = 0.25;

            // act 
            var nameActual = sut.Name;
            var sizeActual = sut.Size.Name;
            var sizePriceActual = sut.Size.Price;
            var crustActual = sut.Crust.Name;
            var crustPriceActual = sut.Crust.Price;

            // assert
            Assert.Equal(nameExpected, nameActual);
            Assert.Equal(sizeExpected, sizeActual);
            Assert.Equal(sizePriceExpected, sizePriceActual);
            Assert.Equal(crustExpected, crustActual);
            Assert.Equal(crustPriceExpeced, crustPriceActual);
        }

        [Fact]
        public void Test_HawaiianPizza_Fact()
        {
            // arrange
            Crust pcrust = new Crust("Regular", 0.25);
            Size psize = new Size("Large", 10.50);
            var sut = new HawaiianPizza(pcrust, psize);
            
            var nameExpected = "Hawaiian Pizza";
            var sizeExpected = "Large";
            var sizePriceExpected = 10.50;
            var crustExpected = "Regular";
            var crustPriceExpeced = 0.25;

            // act 
            var nameActual = sut.Name;
            var sizeActual = sut.Size.Name;
            var sizePriceActual = sut.Size.Price;
            var crustActual = sut.Crust.Name;
            var crustPriceActual = sut.Crust.Price;

            // assert
            Assert.Equal(nameExpected, nameActual);
            Assert.Equal(sizeExpected, sizeActual);
            Assert.Equal(sizePriceExpected, sizePriceActual);
            Assert.Equal(crustExpected, crustActual);
            Assert.Equal(crustPriceExpeced, crustPriceActual);
        }

        [Fact]
        public void Test_PepperoniPizza_Fact()
        {
            // arrange
            Crust pcrust = new Crust("Stuffed", 2.00);
            Size psize = new Size("Large", 10.50);
            var sut = new PepperoniPizza(pcrust, psize);
            
            var nameExpected = "Pepperoni Pizza";
            var sizeExpected = "Large";
            var sizePriceExpected = 10.50;
            var crustExpected = "Stuffed";
            var crustPriceExpeced = 2.00;

            // act 
            var nameActual = sut.Name;
            var sizeActual = sut.Size.Name;
            var sizePriceActual = sut.Size.Price;
            var crustActual = sut.Crust.Name;
            var crustPriceActual = sut.Crust.Price;

            // assert
            Assert.Equal(nameExpected, nameActual);
            Assert.Equal(sizeExpected, sizeActual);
            Assert.Equal(sizePriceExpected, sizePriceActual);
            Assert.Equal(crustExpected, crustActual);
            Assert.Equal(crustPriceExpeced, crustPriceActual);
        }

        [Fact]
        public void Test_SausagePizza_Fact()
        {
            // arrange
            Crust pcrust = new Crust("Thin", 0.25);
            Size psize = new Size("Large", 10.50);
            var sut = new SausagePizza(pcrust, psize);
            
            var nameExpected = "Sausage Pizza";
            var sizeExpected = "Large";
            var sizePriceExpected = 10.50;
            var crustExpected = "Thin";
            var crustPriceExpeced = 0.25;

            // act 
            var nameActual = sut.Name;
            var sizeActual = sut.Size.Name;
            var sizePriceActual = sut.Size.Price;
            var crustActual = sut.Crust.Name;
            var crustPriceActual = sut.Crust.Price;

            // assert
            Assert.Equal(nameExpected, nameActual);
            Assert.Equal(sizeExpected, sizeActual);
            Assert.Equal(sizePriceExpected, sizePriceActual);
            Assert.Equal(crustExpected, crustActual);
            Assert.Equal(crustPriceExpeced, crustPriceActual);
        }

        [Fact]
        public void Test_VeggiePizza_Fact()
        {
            // arrange
            Crust pcrust = new Crust("Stuffed", 2.00);
            Size psize = new Size("Large", 10.50);
            var sut = new VeggiePizza(pcrust, psize);
            
            var nameExpected = "Veggie Pizza";
            var sizeExpected = "Large";
            var sizePriceExpected = 10.50;
            var crustExpected = "Stuffed";
            var crustPriceExpeced = 2.00;

            // act 
            var nameActual = sut.Name;
            var sizeActual = sut.Size.Name;
            var sizePriceActual = sut.Size.Price;
            var crustActual = sut.Crust.Name;
            var crustPriceActual = sut.Crust.Price;

            // assert
            Assert.Equal(nameExpected, nameActual);
            Assert.Equal(sizeExpected, sizeActual);
            Assert.Equal(sizePriceExpected, sizePriceActual);
            Assert.Equal(crustExpected, crustActual);
            Assert.Equal(crustPriceExpeced, crustPriceActual);
        }

        [Fact]
        public void Test_CustomPizza_Fact()
        {
            // arrange
            Crust pcrust = new Crust("Stuffed", 2.00);
            Size psize = new Size("Large", 10.50);
            List<Topping> toppings = new List<Topping>();
            Topping t1 = new Topping("Pepperoni", 1.00);
            Topping t2 = new Topping("Sausage", 1.00);
            Topping t3 = new Topping("Green Peppers", 0.25);
            toppings.Add(t1);
            toppings.Add(t2);
            toppings.Add(t3);
            var sut = new CustomPizza(pcrust, psize, toppings);
            
            var nameExpected = "Custom Pizza";
            var sizeExpected = "Large";
            var sizePriceExpected = 10.50;
            var crustExpected = "Stuffed";
            var crustPriceExpeced = 2.00;
            var toppingsExpected = toppings;

            // act 
            var nameActual = sut.Name;
            var sizeActual = sut.Size.Name;
            var sizePriceActual = sut.Size.Price;
            var crustActual = sut.Crust.Name;
            var crustPriceActual = sut.Crust.Price;
            var toppingsActual = sut.Toppings;

            // assert
            Assert.Equal(nameExpected, nameActual);
            Assert.Equal(sizeExpected, sizeActual);
            Assert.Equal(sizePriceExpected, sizePriceActual);
            Assert.Equal(crustExpected, crustActual);
            Assert.Equal(crustPriceExpeced, crustPriceActual);
            Assert.Equal(toppingsExpected, toppingsActual);
        }


    }
}