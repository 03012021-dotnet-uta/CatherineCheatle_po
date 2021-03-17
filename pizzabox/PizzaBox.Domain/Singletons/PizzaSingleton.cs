using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models;
using PizzaBox.Storing;

namespace PizzaBox.Domain.Singletons
{
    /// <summary>
    /// 
    /// </summary>
    public class PizzaSingleton
    {
        private readonly string _path = @"pizza.xml";
        private readonly string _pathCrust = @"crust.xml";
        private readonly string _pathSize = @"size.xml";
        private readonly string _pathTopping = @"topping.xml";

        private static PizzaSingleton _PizzaSingleton;
        public List<APizza> Pizzas { get; set; }
        public List<Crust> Crusts {get; set;}
        public List<Size> Sizes {get; set;}
        public List<Topping> PizzaToppings {get; set;}

        public static PizzaSingleton Instance 
        { 
            get
            {
                if (_PizzaSingleton == null)
                {
                    _PizzaSingleton = new PizzaSingleton();
                }

            return _PizzaSingleton;
            }
        }

        public void Seeding()
        {
            var pizzas = new List<APizza>
            {
                new CustomPizza(),
                new HawaiianPizza(),
                new CheesePizza(),
                new PepperoniPizza(),
                new SausagePizza(),
                new VeggiePizza()
            };

            var crusts = new List<Crust>
            {
                new Crust("Regular", 0.25),
                new Crust("Thin", 0.25),
                new Crust("Stuffed", 2.00)
            };

            var sizes = new List<Size>
            {
                new Size("Small", 4.50),
                new Size("Medium", 7.50),
                new Size("Large", 10.50)
            };

            var pizzaToppings = new List<Topping>
            {
                new Topping("Pepperoni", 1.00),
                new Topping("Sausage", 1.00),
                new Topping("Ham", 1.00),
                new Topping("Bacon", 1.00),
                new Topping("Black Olives", 0.25),
                new Topping("Green Peppers", 0.25),
                new Topping("Diced Tomatoes", 0.25),
                new Topping("Mushrooms", 0.25),
                new Topping("Spinach", 0.25),
                new Topping("Mixed Onions", 0.25),
                new Topping("Pineapple", 0.25)
            };

            var fs = new FileStorage();

            fs.WriteToXml<APizza>(pizzas, _path);
            fs.WriteToXml<Crust>(crusts, _pathCrust);
            fs.WriteToXml<Size>(sizes, _pathSize);
            fs.WriteToXml<Topping>(pizzaToppings, _pathTopping);

            Pizzas = fs.ReadFromXml<APizza>(_path).ToList();
            Crusts = fs.ReadFromXml<Crust>(_pathCrust).ToList();
            Sizes = fs.ReadFromXml<Size>(_pathSize).ToList();
            PizzaToppings = fs.ReadFromXml<Topping>(_pathTopping).ToList();
        }
    }
}