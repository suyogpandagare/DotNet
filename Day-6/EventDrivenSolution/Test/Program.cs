using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{

    public interface  IWorkable
    {
       void DoWork();
    }

    public interface IPrintbale
    {
        void DoWork();
    }

    public class Worker : IWorkable,IPrintbale
    {
        private  int count = 56;

        void IWorkable.DoWork()
        {
            Console.WriteLine(" Prining.......");
        }

        void IPrintbale.DoWork()
        {
            Console.WriteLine(" Working.......");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Worker theWorker = new Worker();
            IWorkable workable = theWorker;
            workable.DoWork();

            IPrintbale pritable = theWorker;
            pritable.DoWork();
        }
    }
}
