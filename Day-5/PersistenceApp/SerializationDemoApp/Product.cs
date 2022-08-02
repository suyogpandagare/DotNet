using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializationDemoApp
{
    [Serializable]
    public  class Product
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
    }
}
