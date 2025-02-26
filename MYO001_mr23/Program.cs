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

            double fiyat, kar, satisFiyat, kdv, hamkdv;
            Console.Write("Fiyati giriniz: ");
            fiyat = double.Parse(Console.ReadLine());

            Console.Write("kari giriniz: ");
            kar = double.Parse(Console.ReadLine());


            Console.WriteLine("kdv oranı giriniz: ");
            hamkdv = Convert.ToInt32(Console.ReadLine());

            hamkdv = hamkdv / 100;
            satisFiyat = fiyat + kar;
            kdv = satisFiyat + (satisFiyat * hamkdv);


            Console.WriteLine("satis fiyati{0}", satisFiyat);
            Console.WriteLine("kdv dahil satis fiyati{0}", kdv);
            Console.ReadKey();


        }
    }
}
