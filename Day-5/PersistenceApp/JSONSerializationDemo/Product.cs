using System;

namespace JSONSerializationDemo
{

    [Serializable]
    public class Product
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
    }
}
