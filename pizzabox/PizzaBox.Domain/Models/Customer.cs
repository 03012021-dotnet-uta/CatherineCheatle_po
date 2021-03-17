using System.Collections.Generic;

namespace PizzaBox.Domain.Models
{
    public class Customer
    {
        private readonly string _path = @"customer.xml";
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public List<Order> Orders { get; set; }

        public Customer()
        {

        }
        public Customer(string n, string e)
        {
            Name = n;
            Email = e;
            Orders = new List<Order>();
        }

        public void SaveOrderToXML(Customer c)
        {
            System.Xml.Serialization.XmlSerializer writer = new System.Xml.Serialization.XmlSerializer(typeof(Customer));  
         
            //System.IO.FileStream file = System.IO.File.Create(_path);  
            System.IO.FileStream file = System.IO.File.Open(_path, System.IO.FileMode.Append);
    
            writer.Serialize(file, c);  
            file.Close();
        }

        
    }
}