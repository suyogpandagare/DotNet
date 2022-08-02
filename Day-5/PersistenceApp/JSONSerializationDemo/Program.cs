using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;


//Software Design Principle:KISS
//******************Keep it Simple and Stupid
//*****************DRY: Don't reapt your self
//*****************Hollywood: Don't call me , I will call you.

namespace JSONSerializationDemo
{
    internal class Program
    {
        static bool Save(string path, List<Product> products)
        {
            bool status = false;
            try
            {
                string jsonString = JsonSerializer.Serialize(products);
                File.WriteAllText(path, jsonString);
                status = true;

            }
            catch(Exception ee)
            {
                string message = ee.Message;

            }
            finally
            {

            }

            return status;
        }
        static List<Product> Load(string path)
        {
            List<Product> retrivedList = null;
            try
            {
               string retrivedString = File.ReadAllText(path);
               retrivedList = JsonSerializer.Deserialize<List<Product>>(retrivedString);
            }
            catch(Exception ee)
            {
            }
            finally
            {

            }     
            return retrivedList;
        }
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();
            list.Add(new Product { Title = "Gerbera", Description = "Wedding Flower", Quantity = 7600 });
            list.Add(new Product { Title = "Rose", Description = "Valentine Flower", Quantity = 8700 });
            list.Add(new Product { Title = "Orchid", Description = "Delicate Flower", Quantity = 97000 });
            string path = @"d:/try/products.json";
            bool status = false;

            status = Save(path,list);
            List<Product> retrievedList=Load(path);
           
            foreach (Product product in retrievedList)
            {
                Console.WriteLine(product.Title + "  " + product.Quantity + "  " + product.Description);
            }
            Console.ReadLine();
        }
    }
}
