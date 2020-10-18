using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Product.API.Controllers
{
    public static class Products
    {
        private static List<string> ProductItems { get; set; }

        static Products()
        {
          ProductItems= new List<string>();      
        }
        public static async Task<bool> Add(string name)
        {
            ProductItems.Add(name);
            return true;
        }

        public static async Task<int> TotalProducts()
        {
            return ProductItems.Count;
        }

        public static async Task<List<string>> AllProducts()
        {
            return ProductItems;
        }
    }
}
