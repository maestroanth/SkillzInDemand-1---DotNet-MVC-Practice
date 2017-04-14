using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication5.Models
{
    public class Product
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        public int Quantity { get; set; }
    }
}
