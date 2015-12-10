using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2CSharp
{
    class Program
    {
        static void Main(string[] args)
        {

            double dowJones = 4.6;
            double nasdaq = 4.1;
            Console.WriteLine("Dow Jones sjönk med {0} och Nasdaq med {1} procent .", dowJones, nasdaq);
            string city = "Stockholm";
            double stock = 2.4;
            Console.WriteLine("{1} har sjunkit ner med {0} procent", stock, city) ;
            stock = 6.7;
            city = "Milano";
            Console.WriteLine("{1} har sjunkit ner med {0} procent", stock, city);
            stock = 5.5;
            city = "Paris";
            Console.WriteLine("{1} har sjunkit ner med {0} procent", stock, city);

            double PI = Math.PI;
            Console.WriteLine("Talet π är cirka {0:N9} .", PI);
            Console.WriteLine("Men kan avrundas till {0:N2}, ", PI);
            PI = 3;
            Console.WriteLine("och kan lite grovt skrivas som {0} ", PI);

            string name = "Jonas";
            city = "Helsingborg";
            string neiberhood = "Stattena";
            string market = "Hemköp";
            Console.WriteLine("Han heter {0} och bor i {1} på {2} vid {3}.", name, city, neiberhood, market);






            

            

           

        }
    }
}
