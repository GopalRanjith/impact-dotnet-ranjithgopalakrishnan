using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpLearning
{
    public class ProductCatalog
    {
        public static void DisplayProducts(List<Product> products)
        {
            var groupedProducts = products.GroupBy(p => p.Category);

            foreach (var group in groupedProducts)
            {
                Console.WriteLine($"\nCategory : {group.Key}");

                foreach (var product in group)
                {
                    Console.WriteLine($"{product.Name} - ${product.Price}");
                }
            }
        }
    }
}