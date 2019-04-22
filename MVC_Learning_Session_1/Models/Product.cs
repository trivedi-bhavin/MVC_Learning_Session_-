using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_Learning_Session_1.Models
{
    public class Product
    {
        [Display(Name="Product ID")]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        [Display(Name="Price")]
        public int Rate { get; set; }
    }
}