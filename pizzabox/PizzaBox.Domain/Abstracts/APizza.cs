using System.Collections.Generic;
using System.Xml.Serialization;
using PizzaBox.Domain.Models;

namespace PizzaBox.Domain.Abstracts
{
    /// <summary>
    /// 
    /// </summary>
    [XmlInclude(typeof(CheesePizza))]
    [XmlInclude(typeof(CustomPizza))]
    [XmlInclude(typeof(HawaiianPizza))]
    [XmlInclude(typeof(PepperoniPizza))]
    [XmlInclude(typeof(SausagePizza))]
    [XmlInclude(typeof(VeggiePizza))]
    public abstract class APizza
    {
        public Crust Crust { get; set; }
        public Size Size { get; set; }
        public List<Topping> Toppings { get; set; }
        public string Name { get; set; }
        public double Total { get; set; }

        public APizza()
        {
            FactoryMethod();
        }

        private void FactoryMethod()
        {
            AddCrust();
            AddSize();
            AddToppings();
        }

        protected abstract void AddCrust();
        protected abstract void AddSize();
        protected abstract void AddToppings(); 
        public abstract void CalculateTotal();

        public override string ToString()
        {
            return Name;
        }
    }
}