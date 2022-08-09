using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductCatalogApp.Models
{
    //Entity : POCO Object

    [Table("Products")]
    public class Product
    {
        public int Id { get; set; }
        
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        
        [Range(12,40)]
        public int Quantity { get; set; }
    }
}