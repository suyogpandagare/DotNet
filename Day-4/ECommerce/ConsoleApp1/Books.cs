using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Books
    {
        //Indexer---Smart Array
        private string[] titles = new string[5];
        public string this[int index]
        {
            get { return titles[index]; }
            set { titles[index] = value; }
        }
    }
}
