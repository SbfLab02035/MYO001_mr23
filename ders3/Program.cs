namespace ders3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // KDVHesapla();
            // ConvertPracticies();
            // CalculatePay();
            // NotHesapla();
        }
        static void EvKahvesi()
        {
            Dictionary<string, int> kahveler = new Dictionary<string, int>
            { {"Latte", 60 }, { "Americano", 40 }, { "Macchiato", 52 }, { "Filtre", 45 } };
            int i = 0;

            foreach (var kahve in kahveler)
            {
                Console.WriteLine($"{++i}- {kahve.Key}");
            }

            Console.Write("seçiminizi yapınız: ");
            int input01 = int.Parse(Console.ReadLine());

            if (input01 < 1 || input01 > kahveler.Count)
                Console.WriteLine("Hatalı ürün seçimi");
            else
            {
                string selectedKahve = null;
                int selectedPrice = 0;

                i = 0;
                foreach (var kahve in kahveler)
                {
                    i++;
                    if (i == input01)
                    {
                        selectedKahve = kahve.Key;
                        selectedPrice = kahve.Value;
                    }
                }

                Console.Write("Kaç adet: ");
                int input02 = int.Parse(Console.ReadLine());

                int toplamFiyat = selectedPrice * input02;

                Console.WriteLine($"Seçilen Kahve: {selectedKahve}");
                Console.WriteLine($"Toplam fiyat: {toplamFiyat} TL");
            }
        }
        static void NotSirala()
        {
            Console.Write("notunuzu giriniz: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int userNot))
            {
                if (userNot >= 0 && userNot < 45)
                    Console.WriteLine("ff");
                else if (userNot < 50)
                    Console.WriteLine("dd");
                else if (userNot < 55)
                    Console.WriteLine("dc");
                else if (userNot < 60)
                    Console.WriteLine("cc");
                else if (userNot < 70)
                    Console.WriteLine("cb");
                else if (userNot < 80)
                    Console.WriteLine("bb");
                else if (userNot < 90)
                    Console.WriteLine("ba");
                else if (90 <= userNot && userNot <= 100)
                    Console.WriteLine("aa");
            }
            else
            {
                Console.WriteLine("notunuzu tam sayı olarak giriniz");
            }
        }
        static void YasHesapla()
        {
            Console.Write("Yaşınızı giriniz: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int userAge))
            {
                if (userAge >= 0 && userAge < 18)
                    Console.WriteLine("Çocuk");
                else if (userAge < 30)
                    Console.WriteLine("Genç");
                else if (userAge < 50)
                    Console.WriteLine("Olgun");
                else if (49 < userAge)
                    Console.WriteLine("Yaşlı");
            }
            else
            {
                Console.WriteLine("Yaşınızı sayı olarak giriniz");
            }
        }

    }
}
