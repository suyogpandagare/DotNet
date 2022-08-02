using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetTypesApp
{
    public  class Controller
    {
        //Action Methods
        //Action Handlers
        //Receivers
        //Hook function
        //Callback functions
        public  void Display(string name)
        {
            Console.WriteLine("Diplaying Data:" + name);
        }
        public  void Print(string name)
        {
            Console.WriteLine("Printing Data:" + name);
        }

        public void Log(string name)
        {
            Console.WriteLine("Logging  Data:" + name);
        }


    }
}
