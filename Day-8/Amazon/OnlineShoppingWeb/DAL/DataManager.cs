using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;

using OnlineShoppingWeb.Models;
namespace OnlineShoppingWeb.DAL
{
    public class  DataManager
    {
        private  string filePath = @"d:/try/products.json";
        public bool Save(string path, List<Product> products)
        {
            bool status = false;
            try
            {
                string jsonString = JsonSerializer.Serialize(products);
                File.WriteAllText(path, jsonString);
                status = true;

            }
            catch (Exception ee)
            {
                string message = ee.Message;

            }
            finally
            {

            }

            return status;
        }
        public  List<Product> Load(string path)
        {
            List<Product> retrivedList = null;
            try
            {
                string retrivedString = File.ReadAllText(path);
                retrivedList = JsonSerializer.Deserialize<List<Product>>(retrivedString);
            }
            catch (Exception ee)
            {
            }
            finally
            {

            }
            return retrivedList;
        } 
        public Product GetById(int id)
        { 
            List<Product> products = Load(filePath);
            Product foundProduct = products.Find(Product => (Product.Id == id));
            return foundProduct;
        }
        public bool Update(Product emp)
        {
            List<Product> products = Load(filePath);
            bool status = false;
            Product foundProduct= GetById(emp.Id);
            if (foundProduct != null)
            {
                products.Remove(foundProduct);
                products.Add(emp);
                Save(filePath, products);
                status = true;
            }
            return status;
        }
        public bool Insert(Product product)
        {
            List<Product> products = Load(filePath);
            bool status = false;
            products.Add(product);
            Save(filePath, products);
            status = true;
            return status;
        }
        public bool Delete(int id)
        {
            List<Product> products = Load(filePath);
            bool status = false;
            Product foundProduct = GetById(id);
            if (foundProduct != null)
            {
                products.Remove(foundProduct);
                Save(filePath, products);
                status = true;
            }
            return status;
        }
    }
}