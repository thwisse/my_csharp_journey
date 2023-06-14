namespace _15_pre_made_classes_and_functions;
class _3_random_class
{
    static void Main3(string[] args)
    {
        // Random sinifi

        Random rnd = new Random();

        // Next fonksiyonu

        Console.WriteLine(rnd.Next());  // (0 - ...) integer deger araliginda bir sayi uretecek.
        Console.WriteLine(rnd.Next(500)); // (0 - 500) araliginda bir sayi uretecek
        Console.WriteLine(rnd.Next(200, 500)); // (200 - 500) araliginda bir sayi uretecek.

        // rastgele sayi uretirken min deger araligin icindedir. ancak max deger degildir.
        // ustteki ornekte sayi 500 olamaz. ama 200 olabilir.

        // negatif deger uretemez. negatif deger ihtiyacin varsa -1 ile carpabilirsin.


        // NextDouble fonksiyonu

        Console.WriteLine(rnd.NextDouble()); // 0 ile 1 arasinda rastgele deger uretir.

        // cok daha buyuk cusseli sayilar uretmeni saglar.


        char ch = Console.ReadKey(true).KeyChar;
    } 
}
