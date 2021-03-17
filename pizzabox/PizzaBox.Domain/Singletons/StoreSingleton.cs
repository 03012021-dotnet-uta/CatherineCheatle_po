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
    public class StoreSingleton
    {
        private readonly string _path = @"store.xml";
        private static StoreSingleton _storeSingleton;
        public List<AStore> Stores { get; set; }
        
        public static StoreSingleton Instance 
        { 
            get
            {
                if (_storeSingleton == null)
                {
                    _storeSingleton = new StoreSingleton();
                }

            return _storeSingleton;
            }
        }

        private StoreSingleton()
        {
            // var fs = new FileStorage();

            // if(Stores == null)
            // {
            //    Stores = fs.ReadFromXml<Astore>().ToList();
            // }
        }

        public void Seeding()
        {
            var stores = new List<AStore>
            {
                new ChicagoStore(),
                new NewYorkStore()
            };

            var fs = new FileStorage();

            fs.WriteToXml<AStore>(stores, _path);
            Stores = fs.ReadFromXml<AStore>(_path).ToList();
        }
    }
}