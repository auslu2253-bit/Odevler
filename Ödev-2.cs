using System;
using System.Security.Cryptography;

namespace Ödev_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("N değerini giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int[,] matris = new int[sayi, sayi];
            Random rnd = new Random();
            Console.WriteLine("Matris:");
            for (int i = 0; i < sayi; i++)
            {
                for (int j = 0; j < sayi; j++)
                {
                    matris[i, j] = rnd.Next(-9, 10);
                    Console.Write(" " + matris[i, j] + " ");
                }
                Console.WriteLine();
            }
            int toplam1 = 0;
            for (int i = 0; i < sayi; i++)
            {
                toplam1 = toplam1 + matris[i, i];
            }
            int carpim = 1;
            for (int i = 0; i < sayi; i++)
            {
                carpim = carpim * matris[i, sayi - 1 - i];
            }
            int negatif = 0;
            for (int i = 0; i < sayi; i++)
            {
                for (int j = 0; j < sayi; j++)
                {
                    if (matris[i, j] < 0)
                    {
                        negatif++;
                    }
                }
            }
            int enCokSayi = matris[0, 0];
            int enCokTekrar = 1;

            for (int i = 0; i < sayi; i++)
            {
                for (int j = 0; j < sayi; j++)
                {
                    int sayi2 = matris[i, j];
                    int sayac = 0;
                    for (int x = 0; x < sayi; x++)
                    {
                        for (int y = 0; y < sayi; y++)
                        {
                            if (matris[x, y] == sayi2)
                                sayac++;
                        }
                    }
                    if (sayac > enCokTekrar || (sayac == enCokTekrar && sayi2 < enCokSayi))
                    {
                        enCokTekrar = sayac;
                        enCokSayi = sayi2;
                    }
                }
            }
            int toplam2 = 0, asal2 = 0;
            for (int i = 0; i < sayi; i++)
            {
                for (int j = 0; j < sayi; j++)
                {
                    toplam2 = toplam2 + matris[i, j];
                    asal2++;
                }
            }
            Console.WriteLine("Asal köşegen toplamı: " + toplam1);
            Console.WriteLine("Yardımcı köşegen çarpımı: " + carpim);
            Console.WriteLine("Negatif sayı sayısı: " + negatif);
            Console.WriteLine("En çok tekrar eden sayı: " + enCokSayi + " (Tekrar: " + enCokTekrar + ")");
            int asalToplam = 0;
            int asalAdet = 0;
            for (int i = 0; i < sayi; i++)
            {
                for (int j = 0; j < sayi; j++)
                {
                    int sayi2 = matris[i, j];
                    bool asal = true;

                    if (sayi2 < 2)
                        asal = false;
                    else
                    {
                        for (int k = 2; k * k <= sayi2; k++)
                        {
                            if (sayi % k == 0)
                            {
                                asal = false;
                                break;
                            }
                        }
                    }
                    if (asal)
                    {
                        asalToplam += sayi2;
                        asalAdet++;
                    }
                }
            }
            if (asalAdet == 0)
                Console.WriteLine("Asal sayı yok.");
            else
            {
                double ortalama = asalToplam / (double)asalAdet;
                Console.WriteLine("Asal sayıların ortalaması: " + ortalama);
            }
            int[,] yeni = new int[sayi, sayi];
            for (int i = 0; i < sayi; i++)
            {
                for (int j = 0; j < sayi; j++)
                {
                    yeni[j, sayi - 1 - i] = matris[i, j];
                }
            }
            Console.WriteLine("Matrisin 90 derece döndürülmüş hali:");
            for (int i = 0; i < sayi; i++)
            {
                for (int j = 0; j < sayi; j++)
                {
                    Console.Write(yeni[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
