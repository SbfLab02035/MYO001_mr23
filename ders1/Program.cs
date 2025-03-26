namespace ders1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // YasHesapla();
            // NotSirala();
            // EvKahvesi();
        }

        static void NotHesapla()
        {
            int vize1, vize2, proje, final;
            double ortalamaS;
            string ortalamaH = "";

            Console.Write("1. vize giriniz: ");
            vize1 = int.Parse(Console.ReadLine());
            Console.Write("2. vize giriniz: ");
            vize2 = int.Parse(Console.ReadLine());
            Console.Write("1. proje giriniz: ");
            proje = int.Parse(Console.ReadLine());
            Console.Write("1. final giriniz: ");
            final = int.Parse(Console.ReadLine());

            ortalamaS = (double)(0.15 * (vize1 + vize2)) + (0.3 * proje) + (0.4 * final);

            Console.WriteLine($"Ortalama: {ortalamaS}");

            if (ortalamaS > 89)
            {
                ortalamaH = "AA";
            }
            else if (ortalamaS > 79 & ortalamaS < 90)
            {
                ortalamaH = "BA";
            }
            else if (ortalamaS > 69 & (ortalamaS < 80))
            {
                ortalamaH = "BB";
            }
            else if (ortalamaS > 59 & (ortalamaS < 70))
            {
                ortalamaH = "CA";
            }
            else
            {
                ortalamaH = "DD";
            }

            Console.WriteLine($"Harf Notu: {ortalamaH}");
        }
        static void CalculatePay()
        {
            int workInMount, workInDay, pay, payForHour;

            Console.WriteLine("ayda kaç gün çalışıyorsunuz: ");
            workInMount = int.Parse(Console.ReadLine());

            Console.WriteLine("Günde kaç saat çalışıyorsunuz: ");
            workInDay = int.Parse(Console.ReadLine());

            Console.WriteLine("Saatlik ücretiniz: ");
            payForHour = int.Parse(Console.ReadLine());

            pay = workInMount * workInDay * payForHour;
            Console.WriteLine("Maaş: " + pay);
        }
        static void ConvertPracticies()
        {
            int a = 5, b = 2;
            double bolum = (double)a / b; // convert to double
            Console.WriteLine(bolum);

            int a2 = -1;
            byte b2 = (byte)a2;
            Console.WriteLine("b değeri =" + b2);

            double a3 = 259.5;
            byte b3 = (byte)a3;

            char a4 = 'A';
            int b4 = (int)a4;
            Console.WriteLine(b4);


            int birdDate, age;
            Console.Write("Doğum Tarihi");
            birdDate = int.Parse(Console.ReadLine());

            age = 2025 - birdDate;
            Console.WriteLine(age);

        }
        static void KDVHesapla()
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
