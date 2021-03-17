using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
    public class HawaiianPizza : APizza
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
                new Topping("Ham", 1.00),
                new Topping("Pineapple", .25),
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

        public HawaiianPizza()
        {
            Name = "Hawaiian Pizza";
        }

        public HawaiianPizza(Crust c, Size s)
        {
            Name = "Hawaiian Pizza";
            Crust.Name = c.Name;
            Crust.Price = c.Price;
            Size.Name = s.Name;
            Size.Price = s.Price;
        }
    }
}