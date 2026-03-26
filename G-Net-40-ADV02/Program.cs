using G_Net_40_ADV02.DataSeeding;
using G_Net_40_ADV02.Helpers;
using G_Net_40_ADV02.Models;
using G_Net_40_ADV02.Services;

namespace G_Net_40_ADV02
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            List<Product> catalog = DataSeeder.SeedData();
            Console.WriteLine("All Products");
            Printing.PrintProducts(catalog);
            Console.WriteLine(new string('=' , 70));
            Console.WriteLine();
            Console.WriteLine();

            #region  Smart Product Search
            Console.WriteLine("--- Electronics —");
            List<Product> resultName = ProductServices.SearchProducts(catalog, ProductServices.SearchByCategory);
            Printing.PrintProducts(resultName);
            Console.WriteLine(new string('=', 70));
            Console.WriteLine();
            Console.WriteLine();
            



            Console.WriteLine("--- Under 50 --- ");
            List<Product> resultPrice = ProductServices.SearchProducts(catalog, ProductServices.SearchByPrice);
            Printing.PrintProducts(resultPrice);
            Console.WriteLine(new string('=', 70));
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("--- Stock Up  0 --- ");
            List<Product> resultStock = ProductServices.SearchProducts(catalog, ProductServices.SearchByStock);
            Printing.PrintProducts(resultStock);
            Console.WriteLine(new string('=', 70));
            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine("--- Cloting and lower than  100  --- ");
            List<Product> resultCatandPrice = ProductServices.SearchProducts(catalog, p => p.Category == "Clothing" && p.Price < 100);
            Printing.PrintProducts(resultCatandPrice);
            Console.WriteLine(new string('=', 70));
            Console.WriteLine();
            Console.WriteLine();


            /*
             =>  delegate Iam  use  Func<Product , bool> 
            1- built in  delegate   use it Func<Product , bool>  =>  for  search  and return bool  
             we Cannot use  here Action  becuase not return any thing and  i want return  bool  
            we can  use  here prdicate but requirment need it . 

          
             */
            #endregion



            #region Custom Report Generator
            Console.WriteLine("--- Short Report --- ");
            Printing.PrintReports(catalog, ProductServices.PrintShortDetails);
            Console.WriteLine(new string('=', 70));
            Console.WriteLine();
            Console.WriteLine();



            Console.WriteLine("--- Detailed Report --- ");
            Printing.PrintReports(catalog, ProductServices.PrintMoreDetails);
            Console.WriteLine(new string('=', 70));
            Console.WriteLine();
            Console.WriteLine();
            /*
             i am  use here Action  becuause i  am  taking params  and Return any  thing just  using to  print . 
             
             */
            #endregion

            #region Transform Products 
            Console.WriteLine("--- Summary List --- ");
             List<string> resultTransForm1=   Printing.TransformProducts(catalog, ProductServices.SummaryList);
            foreach(var item in resultTransForm1)
                {
                    Console.WriteLine(item);
            }
            Console.WriteLine(new string('=', 70));
            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine("--- Price Labels --- ");
            List<string> resultTransForm2 = Printing.TransformProducts(catalog, ProductServices.PriceLabels);
            foreach (var item in resultTransForm2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(new string('=', 70));
            Console.WriteLine();
            Console.WriteLine();
            /* iam  use Func  becuase   take params and return  string .  built in delegate*/
            #endregion

            #region Filter Products 
            Console.WriteLine("--- Low-Stock Alert --- ");
            List<string> asnwer = ProductServices.FilterProducts(catalog, ProductServices.CheckAboutStock);
            foreach (var item in asnwer) {
                Console.WriteLine(item);
            }
            Console.WriteLine(new string('=', 70));
            Console.WriteLine();
            Console.WriteLine();
            /* use here built  in delegate :  predicate becusae take one params    and return always bool*/
            #endregion
        }
    }
}
