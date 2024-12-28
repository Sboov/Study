namespace Bin2Dec
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write your binary number!");
            int Binary = int.Parse(Console.ReadLine());
            int Lenght = Lenght1(Binary);
            int Decimal = Binary2Decimal(Binary);
            Console.WriteLine("Your Decimal number is: " + Decimal);





        }
        static int Lenght1(int Binary)
        {
            int Lenght = 0;
            if (Binary == 0)
            {
                return 1;
            }
            while (Binary > 0)
            {
                Lenght++;
                Binary /= 10;
            }
            return Lenght;
        }
        public static bool Checker(int Lenght)
        {
            if (Lenght <= 8)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static int Binary2Decimal(int Binary)
        {
            int Decimal = 0;
            int i = 0;
            while (Binary != 0)
            {
                int remainder = Binary % 10;
                Binary /= 10;
                Decimal += remainder * (int)Math.Pow(2, i);
                i++;
            }
            return Decimal;
        }


    }
}
