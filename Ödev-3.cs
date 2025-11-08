namespace Ödev_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen kanguruların hız ve konum değerlerini giriniz ");
            Console.WriteLine("1.Kangurunun konumu: ");
            int konum1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("1.Kangurunun hızı: ");
            int hiz1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.Kangurunun konumu: ");
            int konum2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.Kangurunun hızı: ");
            int hiz2 = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 1; i < i*(i+1); i++)
            {
                konum1 = konum1+hiz1;
                konum2 = konum2+hiz2;
                if (konum1 == konum2)
                {
                    Console.WriteLine("Yes");
                    Console.WriteLine( i + ". zıplayışta ve " + konum1 + " konumunda karşılaşırlar");
                    break;
                }
            }
            if (konum1 != konum2)
            {
                Console.WriteLine("No");
            }
            // 16 7 243 14 girdisi için çıktı: No
            // 89 5 20 3 girdisi için çıktı: No
            // 9 13 44 7 girdisi için çıktı: No

        }
    }
}
