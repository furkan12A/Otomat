using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otomat
{
    internal class Program
    {
        static void Main(string[] args)
        {


            string[] Ürünler = { "Fanta", "Bisküvi", "Çikolata" };
            double[] Fiyat = { 15, 12.5, 7.75 };

            while (true)
            {
                Console.WriteLine("Admin-1\nÜye-2\nÇıkış-3\nSeçiminiz:");
                int secim = Convert.ToInt32(Console.ReadLine());

                if (secim == 1)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        Console.WriteLine("Şifre:");
                        if (Console.ReadLine() == "123")
                        {
                            Console.WriteLine("1-Ekle\n2-Güncelle\n3-Silme\nSeçiminiz:");
                            int admin = Convert.ToInt32(Console.ReadLine());

                            if (admin == 1)
                            {
                                Console.WriteLine("Ürün adı:");
                                string isim = Console.ReadLine();


                                if (Ürünler.Contains(isim)) //Contains => dizide verilen isimde bir kayıt var mı?
                                {
                                    Console.WriteLine("Aynı ürün mevcut");
                                }
                                else
                                {
                                    Console.WriteLine("Fiyat:");
                                    double fiyat = Convert.ToDouble(Console.ReadLine());

                                    Array.Resize(ref Ürünler, Ürünler.Length + 1);
                                    Array.Resize(ref Fiyat, Fiyat.Length + 1);
                                    Ürünler[Ürünler.Length - 1] = isim;
                                    Fiyat[Fiyat.Length - 1] = fiyat;
                                }
                            }
                            else if (admin == 2)
                            {
                                for (int j = 0; j < Ürünler.Length; j++)
                                {
                                    if (Fiyat[j] != 0)
                                        Console.WriteLine($"{j}-{Ürünler[j]}:{Fiyat[j]}");
                                }
                                Console.WriteLine("Ürün Numarası:");
                                int numara = Convert.ToInt32(Console.ReadLine());
                                if (numara > -1 && numara < Ürünler.Length)
                                {
                                    Console.WriteLine("Ürün adı:");
                                    string isim = Console.ReadLine();
                                    Console.WriteLine("Ürün Fiyatı:");
                                    double fiyat = Convert.ToDouble(Console.ReadLine());

                                    Array.Clear(Ürünler, numara, 1);
                                    Array.Clear(Ürünler, numara, 1);

                                    Ürünler[numara] = isim;
                                    Fiyat[numara] = fiyat;
                                }

                                else
                                {
                                    Console.WriteLine("Hatalı Tuşlama");
                                }

                            }
                            else if (admin == 3)
                            {
                                for (int j = 0; j < Ürünler.Length; j++)
                                {
                                    if (Fiyat[j] != 0)
                                        Console.WriteLine($"{j}-{Ürünler[j]}:{Fiyat[j]} tl");
                                }
                                Console.WriteLine("Ürün Numarası:");
                                int numara1 = Convert.ToInt32(Console.ReadLine());
                                if (numara1 > -1 && numara1 < Ürünler.Length)
                                {
                                    Array.Clear(Ürünler, numara1, 1);
                                    Array.Clear(Fiyat, numara1, 1);
                                }
                                else
                                {
                                    Console.WriteLine("Hatalı tuşlama");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Hatalı Tuşlama");
                            }

                            break;
                        }
                        else
                        {
                            Console.WriteLine("Hatalı şifre!!!");
                        }
                    }


                }
                else if (secim == 2)
                {
                    for (int i = 0; i < Ürünler.Length; i++)
                    {
                        Console.WriteLine($"{i + 1}-{Ürünler[i]}:{Fiyat[i]}");
                    }
                    Console.WriteLine("Ürün Numarası:");
                    int numara3 = Convert.ToInt32(Console.ReadLine());

                    if (numara3 > 0 && numara3 <= Ürünler.Length)
                    {
                        double bakiye = 0;
                        while (true)
                        {
                            Console.WriteLine("Para Girişi:");
                            bakiye += Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine(bakiye);
                            if (bakiye >= Fiyat[numara3 - 1])
                            {
                                Console.WriteLine(Ürünler[numara3 - 1] + " alınız.");
                                Console.WriteLine("Yarasın!");
                                Console.WriteLine("Para üstü:" + (bakiye - Fiyat[numara3 - 1]));

                                break;
                            }
                            else
                            {
                                Console.WriteLine("Yetersiz bakiye.");
                                Console.WriteLine("Para Ekleme-1\nÇıkış-2");
                                int E = Convert.ToInt32(Console.ReadLine());

                                if (E != 1)
                                {
                                    Console.WriteLine("Para iade:" + bakiye);
                                    bakiye = 0;
                                    Environment.Exit(0);
                                }


                            }
                        }

                    }
                    else
                    {
                        Console.WriteLine("Hatalı Ürün Tuşlaması!!!!.");
                    }


                }
                else if (secim == 3)
                {
                    Console.WriteLine("yİNE Bekleriz");
                    break;
                }
                else
                {
                    Console.WriteLine("Hatalı Tuşlama!!");
                }
            }
            Console.ReadLine();

        }
    }
}
