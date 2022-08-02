using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetTypesApp
{
    //We would learn now new .net types 
    // Delegates and References:
    // Both of them are Reference Types:
    // Let us try very simple Example
    //Broker, proxy, agent, 
    //adapter

    public delegate void OutputAction(string data);
    public delegate void ArithmaticOperation(int num1, int num2);

    internal class Program
    { 
        static void Main(string[] args)
        {
            //Early Binding
            /*
             Display("Transfllower :Mentor as a Service");
             Print("IECT: Where learning is fun");
            */
            //Late Binding  
            Controller controller = new Controller();
            //Action Handler is getting registered at runtime
            OutputAction action1 = new OutputAction(controller.Print);
            OutputAction action2 = new OutputAction(controller.Display);
            OutputAction action3 = new OutputAction(controller.Log);

            action1.Invoke("India");
            action2.Invoke("Japan");

            OutputAction masterAction = null;
            masterAction = action1;
            masterAction += action2;  //Chaining
                                      //multicast delegate
            masterAction+=action3;
            masterAction.Invoke("Doing ordinary things extraordinarily");

            masterAction-=action1;   // Dechaining
            masterAction.Invoke("Power ...");


            MathsController mathEngine = new MathsController();
            ArithmaticOperation addOperation = new ArithmaticOperation(mathEngine.Add);
            ArithmaticOperation multOperation = new ArithmaticOperation(mathEngine.Mult);

            ArithmaticOperation masterOperation = null;
            masterOperation = addOperation;
            masterOperation+=multOperation;

            //refernce of object is behaving like a function

            masterOperation(67, 45);
            Console.ReadLine();
        }
    }
}
