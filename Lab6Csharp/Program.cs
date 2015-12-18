using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Labb6
{
    class Program
    {
        static void Main(string[] args)
        {
            Literals();   // Uppgigt-1
            Pointer();   // Uppgift-3
            DoubleType();   // Uppgift-4
            Console.ReadKey();

        }


        private static void DoubleType()
        {
            MyDoubleType mdt1 = new MyDoubleType(5);
            Console.WriteLine("mdt1: " + mdt1);

            MyDoubleType mdt2 = mdt1 + 5;
            Console.WriteLine("mdt1 + 5: " + mdt2);

            MyDoubleType mdt3 = mdt1 + mdt2;
            Console.WriteLine("mdt1 + mdt2: " + mdt3);

            MyDoubleType mdt4 = new MyDoubleType(5);
            Console.WriteLine("new MyDoubleType(5): " + mdt4);
            bool b = mdt1 == mdt4;
            Console.WriteLine("mdt1: " + mdt1);
            Console.WriteLine("mdt2: " + mdt2);
            Console.WriteLine("mdt3: " + mdt3);
            Console.WriteLine("mdt4: " + mdt4);

            Console.WriteLine("mdt1: {0}, mdt2: {1}, mdt3: {2}, mdt1 > mdt2: {3}, mdt1 == mdt4: {4}",

                 mdt1, mdt2, mdt3, mdt1 > mdt2, mdt1 == mdt4);
        }

        private static void Pointer()
        {
            Point point = new Point() { X = 10, Y = 20 };
            Console.WriteLine($"Point: {point}");

            Point3D point3D = point;
            Console.WriteLine($"Point3D from Point: {point3D}");

            point3D.Z = 30;
            Console.WriteLine($"Point3D with Z: {point3D}");

            point = (Point)point3D;
            Console.WriteLine($"Point from Point3D: {point}");

            point += point;
            Console.WriteLine($"Point += {point.ToString()}");

            point += point3D;
            Console.WriteLine($"Point + Point3D {point.ToString()}");
        }

       
        private static void Literals()
        {
            float floatNumber = 8.5F;
            long longNummer = 247L;
            ulong ulongNumber = 198UL;
            char charChar = 'b';
            string stringString = "b";
        }
       
    }
   
}
