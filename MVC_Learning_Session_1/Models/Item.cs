using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_Learning_Session_1.Models
{
    //[System.ComponentModel.DataAnnotations.Schema.Table]
    public class Item
    {
        [DisplayName("Product ID")]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public Decimal Rate { get; set; }
    }
}