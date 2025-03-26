namespace ders2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ManavUygulaması();
            // PolinomHesapla();
            // AyseTeyzeninPazarArabasi();
            // IndirimUygula();
            // DovizHesapla();
            // YuzdeHesaplama();
        }

        static void YuzdeHesaplama()
        {
            Console.WriteLine("KDV'siz fiyatını hesaplamak istediğiniz ürünün KDV oranını yüzde cinsinden giriniz: ");
            double kdvOrani = 0.01 * (double.Parse(Console.ReadLine()));
            Console.WriteLine("KDV'siz fiyatını hesaplamak istediğiniz ürünün KDV dahil fiyatını giriniz: ");
            double kdvDahilFiyat = double.Parse(Console.ReadLine());
            double hamDeger = kdvDahilFiyat / (1 + kdvOrani);
            Console.WriteLine($"KDV'siz fiyat: {hamDeger}");
        }
        static void DovizHesapla()
        {
            Dictionary<string, double> doviz = new Dictionary<string, double>
            {
                { "Dolar", 36.42 }, { "Euro", 39.38 }, { "Altın (gram)", 3410.80 }
            };

            Console.WriteLine("Mart 2025 döviz fiyatları (alış): ");
            foreach (var item in doviz)
            {
                Console.WriteLine($"{item.Key}: {(item.Value).ToString("0.00")}");
            }

            Console.WriteLine($"TL cinsinsen mevcut bakiyenizi giriniz: ");
            double bakiye = double.Parse(Console.ReadLine());

            Console.WriteLine("Bakiyenizin döviz karşılığı: ");
            foreach (var item in doviz)
            {
                Console.WriteLine($"{item.Key}: {(bakiye / item.Value).ToString("0.00")}");
            }
        }
        static void IndirimUygula()
        {
            Console.WriteLine("ŞOK İNDİRİM! NE ALIRSAN %35 İNDİRİM");
            Console.Write($"Sepet Tutarınızı giriniz: ");
            int secim = int.Parse(Console.ReadLine());
            Console.WriteLine($"İndirimli Sepet Tutarınız: {secim * 0.65}");
        }
        static void AyseTeyzeninPazarArabasi()
        {
            Dictionary<string, double> meyveFiyatlari02 = new Dictionary<string, double>
            {
                { "elma", 0 }, { "portakal", 0 }, { "limon", 0 }
            };

            double sepetTutari02 = 0;
            foreach (var meyve in meyveFiyatlari02)
            {
                Console.WriteLine($"{meyve.Key} kg fiyatını giriniz: ");
                meyveFiyatlari02[meyve.Key] = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine($"{meyve.Key} ürününden kaç kg aldınız: ");
                meyveFiyatlari02[meyve.Key] = (meyveFiyatlari02[meyve.Key]) * (Convert.ToDouble(Console.ReadLine()));

                sepetTutari02 += meyveFiyatlari02[meyve.Key];
            }

            Console.WriteLine($"sepet tutarınız: {sepetTutari02} TL");
        }
        static void PolinomHesapla()
        {
            Console.Write("4x^3 + 3x^2 + 5x + 2 denkleminin sonucunu bulmak istediğiniz x kökünü giriniz: ");
            int x = int.Parse(Console.ReadLine());
            int sonuc = 4 * x * x * x + 3 * x * x + 5 * x + 2;
            Console.WriteLine($"Sonuç: {sonuc}");
        }
        static void ManavUygulaması()
        {
            Dictionary<string, int> meyveFiyatlari01 = new Dictionary<string, int>
            {
                { "elma", 200 }, { "armut", 240 }, { "muz", 160 }, { "kivi", 300 }, { "çilek", 150 }
            };

            int i = 0, sepetTutari = 0, indirimliSepet;
            List<string> sepet = new List<string>();

            Console.WriteLine("Meyve listesi: ");
            foreach (var meyve in meyveFiyatlari01)
            {
                Console.WriteLine($"{meyve.Key}: {meyve.Value} TL");
            }

            Console.WriteLine("\nMeyve seçin (çıkmak için 'exit' yazın):");
            while (true)
            {
                Console.Write("Meyve adı: ");
                string secilenMeyve = Console.ReadLine().ToLower();

                if (secilenMeyve == "exit")
                {
                    break;
                }

                if (meyveFiyatlari01.ContainsKey(secilenMeyve))
                {
                    sepetTutari += meyveFiyatlari01[secilenMeyve];
                    sepet.Add(secilenMeyve);
                    Console.WriteLine($"{secilenMeyve} sepete eklendi. Güncel sepet tutarı: {sepetTutari} TL");
                }
                else
                {
                    Console.WriteLine("Geçersiz meyve adı. Lütfen listedeki bir meyveyi seçin.");
                }
            }

            Console.WriteLine("\nSepetiniz:");
            foreach (string urun in sepet)
            {
                Console.WriteLine($"{++i}- {urun}");
            }

            Console.WriteLine($"\nToplam tutar: {sepetTutari} TL");

            if (99 < sepetTutari & sepetTutari < 250)
            {
                Console.WriteLine("Sepetiniz 100TL üzerinde olduğu için %10 indirim kazandınız");
                sepetTutari = (int)(sepetTutari * 0.9);
            }
            else if (249 < sepetTutari & sepetTutari < 500)
            {
                Console.WriteLine("Sepetiniz 250TL üzerinde olduğu için %20 indirim kazandınız");
                sepetTutari = (int)(sepetTutari * 0.8);
            }
            else if (499 < sepetTutari)
            {
                Console.WriteLine("Sepetiniz 500TL üzerinde olduğu için %40 indirim kazandınız");
                sepetTutari = (int)(sepetTutari * 0.6);
            }

            if (1000 < sepetTutari)
            {
                Console.WriteLine("Sepetiniz 1000TL üzerinde olduğu için ek %15 indirim kazandınız");
                sepetTutari = (int)(sepetTutari * 0.85);
            }

            Console.WriteLine($"İndirimli sepet tutarı: {sepetTutari} TL");
        }
    }
}
