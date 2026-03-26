using G_Net_40_ADV02.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_Net_40_ADV02.Services
{

   
    public  class ProductServices
    {
        public  static List<Product> SearchProducts(List<Product> products , Func<Product, bool> Filter)
        {
            List<Product> result = new List<Product>();
            foreach(var  product in products)
            {
                if (Filter(product))
                {
                    result.Add(product);
                }
            }
            return result;
        }
        public static bool SearchByCategory(Product product) => product.Category == "Electronics";
        public static bool SearchByPrice(Product product) => product.Price < 50;
        public static bool SearchByStock(Product product) => product.Stock > 0;
        public static bool SearchByPriceAndCategory(Product product) => product.Category == "Clothing" && product.Price <  100;


        public  static  void PrintShortDetails(Product  product)
        {
            Console.WriteLine($"{product.Name} - {product.Price}");
        }


        public static void PrintMoreDetails(Product product)
        {
            Console.WriteLine($"[{product.Category}] {product.Name} | Price:${product.Price} | Stock:{product.Stock}");
        }



        public static string SummaryList(Product product) => $"{product.Name} (${product.Price})";
        
        public  static string PriceLabels(Product product)
        {
            string label = "";
            if (product.Price > 100) label = "Expensive!";
            else label = "Affordable";

            return $"{product.Name} : {label}";
        }


        public static List<string>   FilterProducts(List<Product> products  ,  Predicate<Product>Stocking)
        {
            List<string> result = new List<string>();
          
            foreach (var product in products)
            {
                if(Stocking(product))
                {

                    result.Add($"[LOW STOCK] {product.Name}: only {product.Stock} left!");
                }
            }
            return result;
        }

        public static bool CheckAboutStock(Product product) => product.Stock < 20;
       
    }
}
