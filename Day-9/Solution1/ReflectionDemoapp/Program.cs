using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Reflection;

namespace ReflectionDemoapp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Assembly asm=Assembly.GetExecutingAssembly();
            string assemblyName = asm.FullName;
            Console.WriteLine("Assembly name="+ assemblyName);

            asm.GetTypes(); 

            Type[] types = asm.GetTypes();
            foreach( Type t in types)
            {
                Console.WriteLine(t.FullName);
            }
            string filePath = @"D:\RaviT\DAC\PGDAC\DAC\IET_March22\Dotnet\Day_9\Solution1\GDILib\bin\Debug\GDILib.dll";
            Assembly asm2 = Assembly.LoadFrom(filePath);
            assemblyName = asm2.FullName;
            Console.WriteLine("Assembly name=" + assemblyName);

            asm.GetTypes();

            Type[] typesGDI = asm2.GetTypes();
            foreach (Type t in typesGDI)
            {
                Console.WriteLine("All types of GDILIb class library");
                Console.WriteLine(t.FullName);
                MethodInfo [] methods= t.GetMethods();
                Console.WriteLine("\nAll methods of  {0}", t.FullName);
                foreach( MethodInfo mi in methods)
                {
                    Console.WriteLine(mi.Name);
                }
            }



            Person prn = new Person { Id = 56, FirstName = "Ravi", LastName = "Tambade" };
            Type tPerson=prn.GetType();

            Console.WriteLine(tPerson.FullName);
            PropertyInfo [] properties=tPerson.GetProperties();
            foreach( PropertyInfo pi in properties)
            {
                Console.WriteLine(pi.Name);
            }
            Console.ReadLine();
           }
    }
}
