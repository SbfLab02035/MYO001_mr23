using System.Runtime.InteropServices;

namespace ders5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Random rnd = new Random();

            //for (int i = 0; i < 2;)
            //{
            //    Console.Write(rnd.Next(0, 2));
            //    Console.ForegroundColor = ConsoleColor.Green;
            //    // System.Threading.Thread.Sleep(1);
            //}

            int x = 10;
            for (int i = 0; i <= x; i++)
            {
                Console.WriteLine(i);
                int j = i;

                for (int k = x; k >= 0; k--)
                {
                    Console.WriteLine(k);
                }

                i = j;
            }

        }
    }
}
