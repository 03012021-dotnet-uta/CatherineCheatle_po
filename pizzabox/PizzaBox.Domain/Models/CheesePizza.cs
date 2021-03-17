using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
    public class CheesePizza : APizza
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
                new Topping("Cheese", 0.5),
                new Topping("Cheese", 0.5)
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

        public CheesePizza()
        {
            Name = "Cheese Pizza";
        }

        public CheesePizza(Crust c, Size s)
        {
            Name = "Cheese Pizza";
            Crust.Name = c.Name;
            Crust.Price = c.Price;
            Size.Name = s.Name;
            Size.Price = s.Price;
        }
    }
}