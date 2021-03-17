using System.Collections.Generic;

namespace PizzaBox.Domain.Models
{
    public class Crust : AComponent
    {
        public Crust()
        {
            Name = "";
            Price = 0;
        }
        public Crust(string n, double p)
        {
            Name = n;
            Price = p;
        }
    }
}