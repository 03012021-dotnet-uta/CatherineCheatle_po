using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
    public class PepperoniPizza : APizza
    {
        protected override void AddCrust()
        {
            Crust = new Crust();
        }

        protected override void AddSize()
        {
            Size = new Size();
        }

        protected override void AddToppings()
        {
            Toppings = new List<Topping>
            {
                new Topping("Pepperoni", 1.00),
                new Topping("Cheese", 0.50)
            };
        }
        public override void CalculateTotal()
        {
            double toppingTotal = 0;
            foreach(var t in Toppings)
            {
                toppingTotal += t.Price;
            }

            Total = toppingTotal + Size.Price + Crust.Price; 
        }

        public PepperoniPizza()
        {
            Name = "Pepperoni Pizza";
        }

        public PepperoniPizza(Crust c, Size s)
        {
            Name = "Pepperoni Pizza";
            Crust.Name = c.Name;
            Crust.Price = c.Price;
            Size.Name = s.Name;
            Size.Price = s.Price;
        }
    }
}