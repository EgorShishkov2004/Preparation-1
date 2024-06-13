using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preparation__1.Table
{
    public class Product
    {
        public int Id { get; set; }
        public string Article { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Unit_of_measurement { get; set; } = string.Empty;
        public int Cost { get; set; }
        public int Max_discount { get; set; }
        public string Manufacturer { get; set; } = string.Empty;
        public string Supplier { get; set; } = string.Empty;
        public string Product_category { get; set; } = string.Empty;
        public int Valid_discount { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; } = string.Empty;
        public string Image { get; set; } = string.Empty;
    }
}
