namespace MYO001_mr23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.Write("Hello, World!");
            Console.Write("Hello, World!");

            int a = 5;
            int alan = a * a; 
            int cevre = 4 * a;
            Console.WriteLine("alan: {0}" + " cevre: {1}", alan, cevre);

            double fiyat, kar, satisFiyat;
            Console.Write("Fiyati giriniz: ");
            fiyat = double.Parse(Console.ReadLine());

            Console.Write("kari giriniz: ");
            kar = double.Parse(Console.ReadLine());

            satisFiyat = fiyat + kar;
            Console.WriteLine("sastiş fiyati{0}", satisFiyat);
            Console.ReadKey();
        }
    }
}
