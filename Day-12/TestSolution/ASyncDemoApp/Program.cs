using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Runtime.Remoting.Messaging;

namespace ASyncDemoApp
{

    delegate int BinaryOp(int num1, int num2);
    internal class Program
    {
        //Action function
        public static int Add(int a, int b)
        {
            Console.WriteLine("Addition  work has been started......");
            Console.WriteLine(" Addition Thread ID="+Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(4000);
            Console.WriteLine("Addition  work  will add two numbers......");
            return a + b;
        }

        //CAllBack Function
        //Action Handlers
        public static void OnAddComplete(IAsyncResult iftAr)
        {
            Console.WriteLine(" OnAddComplete is getting exeucted by Thread:" + Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine("Addition Operation is completed.....");
            AsyncResult ar = (AsyncResult)iftAr;
            BinaryOp op = (BinaryOp)ar.AsyncDelegate;
            int Result = op.EndInvoke(iftAr);
            Console.WriteLine("Result =" + Result);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Thread ID="+Thread.CurrentThread.ManagedThreadId);
            //create instance of delegate by passing address of function
            BinaryOp operation1 = new BinaryOp(Add);
            //Blocking Call---synchronous
            // int result= operation1.Invoke(56, 56);
            IAsyncResult iAsync=operation1.BeginInvoke(56, 56, OnAddComplete, null);     
            //Non Blocking Call---asynchronous
            Console.WriteLine("Main thread some task exeuction.....");
           
           Console.ReadLine();
        }
    }
}
