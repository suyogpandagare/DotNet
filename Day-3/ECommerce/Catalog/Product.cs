using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog
{
    //Entity
    //POJO in JAVA <=> POCO

    /*private int id;
    public int Id       //Naive way of declaring property and getter setter
    {                   //Property
        get { return id;  }
        set { id = value;  }
    }*/
    public class Product
    {
        public int Id { get; set; } //Auto property => Effectice way

        public string Title { get; set; }

        public string Description { get; set; }

        public double Price { get; set; }   

        public int Quantity { get; set; }


    }
}
