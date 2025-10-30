namespace Ödev_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Ödev Ahmet Can Uslu 253908060

            int[,] matris = new int[5, 3];
            Random rnd = new Random();
            Console.WriteLine("Üretilen matris: ");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matris[i, j] = rnd.Next(1, 10);
                    Console.Write(matris[i, j] + " ");
                }
                Console.WriteLine();
            }

            int sayi1 = 0, sayi2 = 0, sayi3 = 0;

            for (int i = 0; i < 5; i++)
            {
                sayi1 += matris[i, 0];
                sayi2 += matris[i, 1];
                sayi3 += matris[i, 2];
            }
            Console.WriteLine();
            Console.WriteLine("Sütunların Toplamı: ");
            Console.WriteLine("Sütun 1 Toplam: " + sayi1);
            Console.WriteLine("Sütun 2 Toplam: " + sayi2);
            Console.WriteLine("Sütun 3 Toplam: " + sayi3);
            #endregion
        }
    }
}
