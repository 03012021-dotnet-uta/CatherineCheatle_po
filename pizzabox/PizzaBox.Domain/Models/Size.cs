namespace PizzaBox.Domain.Models
{
    public class Size : AComponent
    {
        public Size()
        {
            Name = "";
            Price = 0;
        }

        public Size(string n, double p)
        {
            Name = n;
            Price = p;
        }
        
    }
}