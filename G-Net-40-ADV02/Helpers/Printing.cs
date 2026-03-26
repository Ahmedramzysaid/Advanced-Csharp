using G_Net_40_ADV02.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_Net_40_ADV02.Helpers
{
    public static class Printing
    {
        static public void PrintProducts(List<Models.Product> products)
        {
         

            foreach (var product in products)
            {
                Console.WriteLine($"{product.Name} - ${product.Price} (Stock: {product.Stock})");
            }
           
        }
        static  public  void PrintReports(List<Product> products  , Action<Product>Data)
        {
            foreach( var product in products)
            {
                Data.Invoke(product);
            }
        }
        static  public  void TransformProducts(List<Product> products , Func<Product , string>DataShapePrint )
        {
            foreach (var item in products)
            {
                Console.WriteLine(DataShapePrint(item));   
            }
        }
    }
}
