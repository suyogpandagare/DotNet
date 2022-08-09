using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;
namespace MultithreadedDemoApp
{
    internal class Program
    {
        //Each Thread  has it's stack

        public static void Display()
        {
            bool status = true;
            Thread thread = Thread.CurrentThread;
            List<string> names = new List<string>();
            string filePath = @"E:\DotNet\Day-12\multithreaddata.txt";
            FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            // create a file object
            // read file data 
            // copy file data into List<string>

            // File, database connection, network stream,
            // Memory Stream, Socket instances

            //What do you mean by Thread synchronization
            lock(fs)
            { 
                
                Console.WriteLine("Secondary Thread Execution.....");
                Console.WriteLine("Invoking Display Logic..........................");
                Console.WriteLine(thread.ManagedThreadId);
                Console.WriteLine(thread.Priority.ToString());
                //code segment for manipulating data availabe in list
                //WRite modified data back to file.
                fs.Close();
                Thread.Sleep(1000);
            }

        }
        static void Main(string[] args)
        {
            Thread.Sleep(3000);
            
            Thread ThreadMain= Thread.CurrentThread;
            Console.WriteLine(ThreadMain.ManagedThreadId);
            Console.WriteLine(ThreadMain.Priority.ToString());
            //Thread Priority levels
            //1.Highest
            //2.Above Normal
            //3.Normal
            //4.Below Normal
            //5.Lowest
            ThreadStart  th= new ThreadStart(Display);

            Thread secondaryThread1 = new Thread(th);
            secondaryThread1.Start();    //this thread1 will start here
            secondaryThread1.Join();
            Thread secondaryThread2=new Thread(th);
            secondaryThread2.Start();    //this thread1 will start here
           

            while (true)
            {
                Thread thread = Thread.CurrentThread;

                Console.WriteLine("Secondary Thread Execution.....");
                Console.WriteLine("Invoking Main EntryPoint Logic..........................");
                Console.WriteLine(thread.ManagedThreadId);
                Console.WriteLine(thread.Priority.ToString());
                Thread.Sleep(4000);
            }

            Console.WriteLine("Work has been resumed.....");
            Console.ReadLine();
           
        }
    }
}
