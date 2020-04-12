using System;

namespace PersonalProjectLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the lumber calculator!");
            int length;
            int width;
            int thickness;
            string var;
            decimal boardFt;
            string cont;
            decimal price = 1;
            decimal total;

            do
            {

                Console.WriteLine("Please enter the length in whole inches");
                var = Console.ReadLine();
                length = int.Parse(var);

                Console.WriteLine("Please enter the width in whole inches");
                var = Console.ReadLine();
                width = int.Parse(var);

                Console.WriteLine("Please enter the thickness in whole inches");
                var = Console.ReadLine();
                thickness = int.Parse(var);

                Console.WriteLine("Please select the number for the species of wood");
                Console.WriteLine("1 = Oak");
                Console.WriteLine("2 = Southern Yellow Pine");
                Console.WriteLine("3 = Maple");
                Console.WriteLine("4 = Walnut");
                Console.WriteLine("5 = Poplar");
                Console.WriteLine("6 = Macassar Ebony");

                string species = Console.ReadLine();
                switch (species)
                {
                    case "1":
                        price = 11.80m;
                        break;
                    case "2":
                        price = 2.65m;
                        break;
                    case "3":
                        price = 5.00m;
                        break;
                    case "4":
                        price = 11.10m;
                        break;
                    case "5":
                        price = 3.00m;
                        break;
                    case "6":
                        price = 80.00m;
                        break;  
                }

                BFcalc boardFootage = new BFcalc();
                boardFt = boardFootage.CalculateBoardFootage(length, width, thickness);

                total = boardFt * price;

                Console.WriteLine("You need " + boardFt + " board feet (foot)");

                Console.WriteLine("Your total price is $" + total);

                Console.WriteLine("Would you like to make another calculation? please enter 'yes' or 'no'");
                cont = Console.ReadLine();
            }

            while (cont == "yes");

            Console.WriteLine("Enjoy your woodworking project!");
        }
    }
}