using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace SerializationDemoApp
{
    internal class Program
    {
        static bool Save(string path, List<Product> products)
        {
            bool status = false;
            try
            {
                FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                BinaryFormatter formatter = new BinaryFormatter();
                //Serialization process
                formatter.Serialize(fileStream, products);
                fileStream.Close();
                status = true;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {

            }
            return status;

        }

        static List<Product> Load(string path)
        {
            FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
            BinaryFormatter formatter = new BinaryFormatter();
            List<Product> products = null;
            try
            {
                products = formatter.Deserialize(fileStream) as List<Product>;
                fileStream.Close();
            }
            catch(Exception ee)
            {
                string expMessate = ee.Message;
            }
            finally
            {

            }
            return products;
        }
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();
            list.Add(new Product { Title="Gerbera", Description="Wedding Flower",  Quantity=7600});
            list.Add(new Product { Title = "Rose", Description = "Valentine Flower", Quantity = 8700 });
            list.Add(new Product { Title = "Orchid", Description = "Delicate Flower", Quantity = 97000 });
            string path = @"d:/try/data.dat";
            
            bool status= Save(path, list);

            List<Product> retrivedList = null;
            retrivedList = Load(path);

            foreach(Product product in retrivedList)
            {
                Console.WriteLine(product.Title +"  " +  product.Quantity+ "  " + product.Description);
            }

            Console.ReadLine();
        }
    }
}
