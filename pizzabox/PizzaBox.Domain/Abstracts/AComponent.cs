using System.Xml.Serialization;
using PizzaBox.Domain.Models;

namespace PizzaBox.Domain.Models
{
    /// <summary>
    /// 
    /// </summary>
    [XmlInclude(typeof(Crust))]
    [XmlInclude(typeof(Size))]
    [XmlInclude(typeof(Topping))]
    public abstract class AComponent
    {
        public string Name { get; set; }
        public double Price { get; set; }
        
    }
}