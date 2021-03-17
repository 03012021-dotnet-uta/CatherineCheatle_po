using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
    public class VeggiePizza : APizza
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
                new Topping("Mushrooms", 0.25),
                new Topping("Diced Tomatoes", 0.25),
                new Topping("Green Peppers", 0.25),
                new Topping("Black Olives", 0.25),
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

        public VeggiePizza()
        {
            Name = "Veggie Pizza";
        }

        public VeggiePizza(Crust c, Size s)
        {
            Name = "Veggie Pizza";
            Crust.Name = c.Name;
            Crust.Price = c.Price;
            Size.Name = s.Name;
            Size.Price = s.Price;
        }
    }
}