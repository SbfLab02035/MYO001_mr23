namespace MYO001_mr23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // KDVHesapla();
            // ConvertPracticies();
            // CalculatePay();
            // NotHesapla();

            // ManavUygulaması();
            // PolinomHesapla();
            // AyseTeyzeninPazarArabasi();
            // IndirimUygula();
            // DovizHesapla();
            // YuzdeHesaplama();

            // YasHesapla();
            // NotSirala();

            Dictionary<string, int> kahveler= new Dictionary<string, int>
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
