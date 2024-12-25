using System.Reflection.Metadata.Ecma335;
using System.Security.AccessControl;
using System.Xml.Serialization;

namespace Rock_Paper_Scissors
{
    internal class RockPaperScissors
    {
        static void Main(string[] args)
        {
            string wyborGracza = Player();
            string wyborKomputer = Computer();

            Console.WriteLine($"Wybór komputera to: {wyborKomputer}");
            Console.WriteLine($"Wybór gracza to: {wyborGracza}");

            string wynik = WinOrLoss(wyborGracza, wyborKomputer);
            Console.WriteLine(wynik);

            Console.ReadKey();
        }

        public static string Computer()
        {
            string[] Objects = { "Kamień", "Papier", "Nożyce" };

            Random n = new Random();
            int LosowanaLiczba = n.Next(0, Objects.Length);

            string AIchoice = Objects[LosowanaLiczba];
            Console.WriteLine(AIchoice);
            return AIchoice;
        }

        public static string Player()
        {
            Console.WriteLine("Witaj w grze Kamień-Papier-Nożyce.\nJaki jest twój wybór?\nK - Kamień\nP - Papier\nN - Nożyce");
            string? WybranaRzecz = Console.ReadLine();
            string choice;
            switch (WybranaRzecz)
            {
                case "K":
                case "k":
                    choice = "Kamień";
                    break;
                case "P":
                case "p":
                    choice = "Papier";
                    break;
                case "N":
                case "n":
                    choice = "Nożyce";
                    break;
                default:
                    choice = "Error";
                    break;
            }
            return choice;
        }





        public static int Convertor(string wybor)
        {
            string[] Objects = { "Kamień", "Papier", "Nożyce" };
            return Array.IndexOf(Objects, wybor);
        }




        public static string WinOrLoss(string wyborGracza, string wyborKomputer)
        {
            int graczIndex = Convertor(wyborGracza);
            int komputerIndex = Convertor(wyborKomputer);

            if (graczIndex == -1 || komputerIndex == -1)
            {
                return "Błąd: Nieprawidłowy wybór!";
            }

            if (graczIndex == komputerIndex)
            {
                return "Remis!";
            }

            
            if ((graczIndex == 0 && komputerIndex == 2) || 
                (graczIndex == 1 && komputerIndex == 0) || 
                (graczIndex == 2 && komputerIndex == 1))   
            {
                return "Wygrałeś!";
            }

            return "Przegrałeś!";
        }


    }
}