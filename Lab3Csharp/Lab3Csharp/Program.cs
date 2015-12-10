using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //PersonMethod();
            //PrintPersonFavTeam();
            PrintCircleCircumferenceMethod();
            //PrintCircle2CircumferenceMethod();
            //FavoritTeamMethod();
            //PrintTeamMethod();
            //PrintCircle3Method();


        }

        private static void PrintCircle3Method()
        {
            Circle circle3 = new Circle();
            Point point2 = new Point();
            point2.SetX(3);
            point2.SetY(2);
            circle3.SetDiameter(5.8);
            Console.WriteLine(circle3.GetCircumference());
        }

        private static void PrintTeamMethod()
        {
            Team barcelona = new Team();
            barcelona.SetName("Barcelona");
            barcelona.SetCountry("Spanien");
            barcelona.SetNumberOfFans(10000000);
            Console.WriteLine("Fotbollslaget heter {0} och kommer från {1} och har {2} fans över hela världen.", barcelona.GetName(), barcelona.GetCountry(), barcelona.GetNumberOfFans());
            Team fotbollsTeam2 = new Team();
            fotbollsTeam2.SetName("Paris Saint Germaint");
            fotbollsTeam2.SetCountry("Frankrike");
            fotbollsTeam2.SetNumberOfFans(20000000);
            Console.WriteLine($"Fotbollslaget heter {fotbollsTeam2.GetName()} och kommer från {fotbollsTeam2.GetCountry()} och har {fotbollsTeam2.GetNumberOfFans()} fans över hela världen.");
            Console.WriteLine("Vad heter din favorit fotbollslag?");
        }

        private static void FavoritTeamMethod()
        {
            Team team1 = new Team();
            Console.WriteLine("Vad är din favorit sport?");
            string favoritSport1 = Console.ReadLine();
            team1.SetSport(favoritSport1);
            Console.WriteLine("Och vad heter din favorit lag?");
            string favoritTeam1 = Console.ReadLine();
            team1.SetName(favoritTeam1);
            Console.WriteLine("Varifrån kommer ditt lag?");
            string teamCountry1 = Console.ReadLine();
            team1.SetCountry(teamCountry1);
            Console.WriteLine("Hur många hejar på har ditt favorit lag?");
            int fansNumber1 = int.Parse(Console.ReadLine());
            team1.SetNumberOfFans(fansNumber1);
            Console.WriteLine("Din favorit sport är {0} och ditt favorit lag heter {1} som kommer från {2} och har {3} fans.", team1.GetSport(), team1.GetName(), team1.GetCountry(), team1.GetNumberOfFans());
            
        }

        private static void PrintCircle2CircumferenceMethod()
        {
            Point point = new Point();
            point.SetX(3);
            point.SetY(2);
            Circle circle2 = new Circle();
            circle2.SetName("Min circle");
            circle2.SetDiameter(2.6);
            circle2.SetCenter(point);
            Console.WriteLine("{0:N3} har en omkrets på {1}",circle2.GetName(), circle2.GetCircumference());
            Console.WriteLine($"Circle 2 har en omkrets på {circle2.GetCircumference()}");
        }

        private static void PrintCircleCircumferenceMethod()
        {
            Circle circle = new Circle();
            circle.SetDiameter(-1.5);
            Console.WriteLine(circle.GetCircumference());
        }

        private static void PrintPersonFavTeam()
        {
            Person youness = new Person();
            Team hif = new Team();
            youness.SetName("Youness");
            youness.SetTeam(hif);
            hif.SetSport("Fotboll");
            hif.SetName("HIF");
            hif.SetCountry("Sverige");
            Console.WriteLine("{0} tycker om {1} och har {2} som favorit lag som kommer från {3}.", youness.GetName(), hif.GetSport(), hif.GetName(), hif.GetCountry());
        }

        private static void PersonMethod()
        {
            Person adam = new Person();
            adam.SetName("Adam");
            Console.WriteLine(adam.GetName());
        }
    }
}






