namespace PizzaBox.Domain.Models
{
    public class Topping: AComponent
    {
        public Topping()
        {
            Name = "";
            Price = 0;
        }

        public Topping(string n, double p)
        {
            Name = n;
            Price = p;
        }
       
    }
}