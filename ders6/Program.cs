namespace ders6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // İç İçe döngüler
            //for (int i = 0; i < 10; i++)
            //{
            //    for (int j = 10; j > 0; j--)
            //    {
            //        Console.Write("*");

            //    }
            //    Console.WriteLine();
            //}

            // diziler
            //double[] a = { 55, 60, 70, 40, 20, 60};
            //int gecen = 0;
            //for (int i = 0;i < a.Length; i++) if(a[i] >= 50) gecen++;
            //Console.WriteLine($"gecen sayısı: {gecen}");
            //Console.WriteLine($"barasi orani: {gecen*100/(a.Length)}");

            // ornek1
            //Console.WriteLine("ogrenci sayısını giriniz");
            //int ogr = int.Parse(Console.ReadLine());
            //int basari = 0;
            //double[] liste = new double[ogr];

            //Console.WriteLine("\notları giriniz");
            //for (int i = 0; i < ogr; i++)
            //{
            //    liste[i] = int.Parse(Console.ReadLine());
            //    if(liste[i] >= 50) basari++;
            //}

            //Console.WriteLine("\nGirilen notlar");
            //for (int i = 0; i < ogr; i++)
            //{
            //    Console.WriteLine($"{i + 1}. sayı: {liste[i]}");
            //}

            //Console.WriteLine($"\nBaşarı yüzdesi: {100*basari/(ogr)}");

            //Console.WriteLine($"\nSilme işlemi sonrası");

            //Array.Clear(liste, 0, 3);

            //for (int i = 0; i < ogr; i++)
            //{
            //    Console.WriteLine($"{i + 1}. sayı: {liste[i]}");
            //}

            // ornek2
            int[] liste = { 10, 20, 30, 40, 50};
            int n =liste.Length;
            int[] b = new int[n];
            for (int i = 0; i < n; i++) 
                Console.WriteLine($"{liste[i]} ");
            for (int i = 0; i < n; i++)
                b[i] = liste[n-i-1];
            Console.WriteLine();
            for (int i = 0; i < n; i++)
                Console.WriteLine($"{b[i]} ");

        }
    }
}
