namespace Choinka_Łukasza
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 4;
            for (int poziom = 0; poziom < n; poziom++)
            {
                int szerokosc = 1 + 2 * poziom; 
                int spacje = n - poziom - 1; 


                for (int i = 0; i < spacje; i++)
                {
                    Console.Write(" ");
                }


                for (int i = 0; i < szerokosc; i++)
                {
                    Console.Write("#");
                }

                Console.WriteLine();
            }
            for (int i = 0; i < n - 1; i++)
            {
                Console.Write(" ");
            }
            Console.WriteLine("#");
        }
    }
}
