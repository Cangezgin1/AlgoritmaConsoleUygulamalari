using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_AlgoritmaConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 16-1 İkiSayınınKıyaslaması
            char c;
            int a = 0, b = 0;
        basadon:
            Console.Clear();
            Console.WriteLine("1.Sayıyı giriniz: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.Sayıyı giriniz: ");
            b = Convert.ToInt32(Console.ReadLine());
            if (a < b)
                Console.WriteLine("1.Sayı 2.Sayıdan küçüktür..");
            else if (a == b)
                Console.WriteLine("1.Sayı ve 2. Sayı birbirine eşittir.");
            else
                Console.WriteLine("1.Sayı 2.Sayıdan büyüktür..");
            Console.WriteLine("Tekrar denemek ister misiniz? e/h?");
            c = Convert.ToChar(Console.ReadLine());
            if (c == 'e' || c == 'E')
                goto basadon;
            else
                Console.WriteLine("İyi günler dilerim... :)");
            Console.ReadLine();
            #endregion

            #region 16-2 TekmiÇiftmi
            int a = 0;
            char b;
        basadon:
            Console.Clear();
            Console.WriteLine("Sayıyı giriniz :");
            a = Convert.ToInt32(Console.ReadLine());
            if (a % 2 == 0)
                Console.WriteLine("Girdiğiniz sayı çifttir.");
            else
                Console.WriteLine("Girdiğiniz sayı tektir.");
            Console.WriteLine("Tekrar denemek ister misiniz? (e/h)");
            b = Convert.ToChar(Console.ReadLine());
            if (b == 'e' || b == 'E')
                goto basadon;
            else
                Console.WriteLine("İyi Günler Dileriz...");
            Console.ReadLine();
            #endregion

            #region 16-3 100SayınınToplamı
            int a = 0, sayac = 0, toplam = 0;
        basadon:
            Console.Clear();
            Console.WriteLine("100 Sayının Toplamı İçin Sayıları Giriniz : ");
            a = Convert.ToInt32(Console.ReadLine());
            sayac += 1;
            if (sayac <= 100)
            {
                toplam += a;
                goto basadon;
            }
            else
                Console.WriteLine("Toplamları :{0}", toplam);
            Console.ReadLine();
            #endregion

            #region 16-4 20SayıdanPozitifNegatif
            int sayı = 0, sayac = 0, sayac1 = 0, sayac2 = 0;
        basadon:
            Console.Clear();
            Console.WriteLine("20 tane sayı giriniz : ");
            sayı = Convert.ToInt32(Console.ReadLine());
            sayac += 1;
            if (sayac <= 20)
            {
                if (sayı < 0)
                {
                    sayac1 += 1;
                }
                else
                {
                    sayac2 += 1;
                }
                goto basadon;
            }
            Console.WriteLine("Girdiğiniz Sayılardan " + sayac1 + " tanesi Negatif, " + sayac2 + " tanesi Pozitif.");
            Console.ReadLine();
            #endregion

            #region 16-5 0GirileneKadarToplam
            int toplam = 0, sayı = 0;
        basadon:
            Console.WriteLine("Lütfen Sayı Giriniz : ");
            sayı = Convert.ToInt32(Console.ReadLine());
            toplam += sayı;
            if (sayı != 0)
            {
                goto basadon;
            }
            else
            {
                Console.WriteLine("Girdiğiniz Sayıların Toplamı : " + toplam);
            }
            Console.ReadLine();
            #endregion

            #region 16-6 20SayıdanTeklerinKaresiÇiftlerinKüpü
            int sayı = 0, t = 0, ç = 0, sayac = 0;
        basadon:
            Console.WriteLine("Sayı Giriniz: ");
            sayı = Convert.ToInt32(Console.ReadLine());
            sayac += 1;
            if (sayac <= 20)
            {
                if (sayı % 2 == 0)
                {
                    ç = (sayı * sayı * sayı);
                    Console.WriteLine("Sayınızın kübü :" + ç);
                    goto basadon;
                }
                else
                {
                    t = (sayı * sayı);
                    Console.WriteLine("Sayınızın karesi :" + t);
                    goto basadon;
                }
            }
            else
            {
                Console.WriteLine("TEŞEKKÜRLER İYİ GÜNLER :)");
            }
            Console.ReadLine();
            #endregion

            #region 16-7 VizeFinalNotunaGöreBütünleme
            int b = 0, ort = 0, v = 0, f = 0;
            Console.WriteLine("Vize Notu Giriniz: ");
            v = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Final Notu Giriniz: ");
            f = Convert.ToInt32(Console.ReadLine());
            ort = (v + f) / 2;
            if (ort < 50)
            {
                Console.WriteLine("Kaldınız Bütünleme Sınavına Giriniz.\nBütünleme Notu Giriniz: ");
                b = Convert.ToInt32(Console.ReadLine());
                if (b < 50)
                {
                    Console.WriteLine("Kaldınız Seneye Görüşürüz :)))");
                }
                else
                {
                    Console.WriteLine("Geçtiniz TEBRİKLER :)");
                }
            }
            else
            {
                Console.WriteLine("Geçtiniz TEBRİKLER :)");
            }
            Console.ReadLine();
            #endregion

            #region 16-8 Basit4İşlem
            int sayı1 = 0, sayı2 = 0, t = 0, ç = 0, çarpma = 0;
            float b = 0f;
            string sec = "";
            ; Console.WriteLine("Büyük Olan Sayıyı Giriniz: ");
            sayı1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Küçük Olan Sayıyı Giriniz: ");
            sayı2 = Convert.ToInt32(Console.ReadLine());
        basadon:
            Console.WriteLine("İşlem Tipi Giriniz ; \nİşlem1\nİşlem2\nİşlem3\nİşlem4");
            sec = Console.ReadLine();
            if (sec == "İşlem1")
            {
                t = sayı1 + sayı2;
                Console.WriteLine("Sayıların toplamı: " + t);
            }
            else if (sec == "İşlem2")
            {
                ç = sayı1 - sayı2;
                Console.WriteLine("Sayıların farkı: " + ç);
            }
            else if (sec == "İşlem3")
            {
                çarpma = sayı1 * sayı2;
                Console.WriteLine("Sayıların çarpımı: " + çarpma);
            }
            else if ((sec == "İşlem4"))
            {

                b = (sayı1 / sayı2);
                Console.WriteLine("Sayıların bölümü: " + b);

            }
            else
            {
                Console.WriteLine("Lütfen işlem tipini tekrar seçiniz...");
                goto basadon;
            }
            Console.ReadLine();
            #endregion

            #region 16-9 10ÖğrenciDönemSonuNotOrt
            float sayac = 0, ort = 0, vize = 0, final = 0;
        basadon:
            Console.Clear();
            Console.WriteLine("Vize Notu Giriniz: ");
            vize = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Final Notu Giriniz: ");
            final = Convert.ToInt32(Console.ReadLine());
            sayac += 1;
            ort = ort + ((4 * vize) / 10) + ((6 * final) / 10);
            if (sayac <= 10)
            {
                goto basadon;
            }
            else
            {
                ort = ort / 10;
                Console.WriteLine("10 Öğrencinin dönem sonu not ortalaması :" + ort);
            }
            Console.ReadLine();
            #endregion

            #region 16-10 SayınınFaktoriyeli
            int sayı = 0, sonuç = 1, sayac = 0;
            Console.WriteLine("Sayı Giriniz : ");
            sayı = Convert.ToInt32(Console.ReadLine());
        a:
            sayac += 1;
            sonuç = sonuç * sayac;
            if (sayac < sayı)
            {
                goto a;
            }
            else
            {
                Console.WriteLine("Sayının faktoriyeli : " + sonuç);
                Console.ReadLine();
            }
            #endregion

            #region 16-11 Çarpım Toblosu
            int i = 1, s = 0, j = 1;
        basadon:
            s = i * j;
            Console.WriteLine(s);
            if (j <= 9)
            {
                j += 1;
                goto basadon;
            }
            else if (i <= 9)
            {
                i += 1;
                goto basadon;
            }
            Console.ReadLine();
            #endregion

            #region 16-12 GirilenSayıKaçBasamaklı
            float x = 0, sayı = 0;
            Console.WriteLine("Sayı giriniz: ");
            sayı = Convert.ToInt32(Console.ReadLine());
        basadon:
            sayı = sayı / 10;
            x += 1;
            if (sayı > 1)
            {
                goto basadon;
            }
            else
            {
                Console.WriteLine("Sayının " + x + " basamaklıdır...");
            }
            Console.ReadLine();
            #endregion

            #region 16-13 MağzadanBelliÜrüneİndirim
            int x = 0, y = 0;
            Console.WriteLine("Ürün sayısı giriniz :");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ürün Fiyatlarını giriniz :");
            y = Convert.ToInt32(Console.ReadLine());
            if (x < 3)
            {
                Console.WriteLine("Ürün sayısı " + x + " \nÜrün fiyatı ise " + y + " dir");
            }
            else
            {
                y = (y * 7) / 10;
                Console.WriteLine("Ürün sayısı " + x + " \nÜrün fiyatı ise " + y + " dir");
            }
            Console.ReadLine();
            #endregion

            #region 16-14 10SayıdanEnKüçcüğüBulma

            int sayı = 0, sayaç = 0, x = 0;
        basadon:
            Console.Clear();
            Console.WriteLine("10 tane sayı giriniz :");
            sayı = Convert.ToInt32(Console.ReadLine());
            sayaç += 1;
            if (sayaç < 10)
            {
                if (x < sayı)
                    x = sayı;
                goto basadon;
            }
            else
                Console.WriteLine("Girdiğiniz en küççük sayı : " + sayı);
            Console.ReadLine();

            #endregion


        }
    }
}
