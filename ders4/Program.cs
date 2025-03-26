using System;

namespace ders4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // MevsimSec();
            // CezaHesapla();

        }

        static void CezaHesapla()
        {
            Console.Write("Hiz siniri giriniz (km/s): ");
            int hizSiniri = Int32.Parse(Console.ReadLine());
            Console.Write("Hizinizi giriniz (km/s): ");
            int arabaHiz = Int32.Parse(Console.ReadLine());
            double hesap = ((double)(arabaHiz - hizSiniri) / hizSiniri) * 100;
            Console.Write("Cüzdanınızdaki bakiye (TL): ");
            int cuzdan = Int32.Parse(Console.ReadLine());

            if (hesap <= 10) hesap = 1;
            else if (10 < hesap && hesap <= 30) hesap = 2;
            else if (30 < hesap && hesap <= 50) hesap = 3;
            else if (50 < hesap) hesap = 4;

            int cezaTL = 0, cezaPuan = 0;
            switch (hesap)
            {
                case 1:
                    Console.WriteLine("Hiz Sinirinin Üzerindesiniz");
                    break;
                case 2:
                    cezaTL += 314;
                    cezaPuan += 10;
                    cuzdan -= cezaTL;
                    break;
                case 3:
                    cezaTL += 652;
                    cezaPuan += 15;
                    cuzdan -= cezaTL;
                    break;
                case 4:
                    cezaTL += 1340;
                    cezaPuan += 15;
                    cuzdan -= cezaTL;
                    break;
                default:
                    Console.WriteLine("Bir hata oluştu");
                    break;
            }

            Console.WriteLine($"ceza tutarı: {cezaTL}\nceza puanı: {cezaPuan}\ngüncel cüzdanınız: {cuzdan}");
        }
        static void MevsimSec()
        {
            Console.Write("bir mevsim seçiniz: ");
            int control = Int32.Parse(Console.ReadLine());

            switch (control)
            {
                case 1:
                    Console.WriteLine("Ilkbahar");
                    break;

                case 2:
                    Console.WriteLine("Yaz");
                    break;

                case 3:
                    Console.WriteLine("Sonbahar");
                    break;

                case 4:
                    Console.WriteLine("Kıs");
                    break;

                default:
                    break;
            }
        }
    }
}
