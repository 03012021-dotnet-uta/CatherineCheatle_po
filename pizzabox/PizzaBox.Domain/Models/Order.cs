using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
    public class Order
    {
        private readonly string _path = @"order.xml";
        public List<APizza> Pizzas { get; set; }
        public string StoreName { get; set; }
        public Customer Cust { get; set; }
        public double Total { get; set; }
        private double tax = 1.07;

        public Order()
        {

        }
        public Order(List<APizza> p, string n, Customer c)
        {
            Pizzas = p;
            StoreName = n;
            Cust = c;
        }

        public double calcTotal()
        {
            foreach(var op in Pizzas)
            {
                op.CalculateTotal();
                Total += op.Total;
            }

            return Total * tax;
        }

        public void SaveOrderToXML(Order o)
        {
            
            // System.Xml.Serialization.XmlSerializer writer = new System.Xml.Serialization.XmlSerializer(typeof(Order));  
         
            // System.IO.FileStream file = System.IO.File.Create(_path);  
    
            // writer.Serialize(file, o);  
            // file.Close();

            System.Xml.Serialization.XmlSerializer writer = new System.Xml.Serialization.XmlSerializer(typeof(Order));  
         
            //System.IO.FileStream file = System.IO.File.Create(_path);  
            System.IO.FileStream file = System.IO.File.Open(_path, System.IO.FileMode.Append);
    
            writer.Serialize(file, o);  
            file.Close();
        }


    }
}