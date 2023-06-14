namespace _15_pre_made_classes_and_functions;
class _1_math_functions
{
    static void Main1(string[] args)
    {
        // Math kutuphanesi

        // Abs (absolute value) (mutlak deger hesabi)
        
        Console.WriteLine(Math.Abs(5) + " ve " + Math.Abs(-5)); /// 5 ve 5

        // Ceiling (yukari yuvarlama)

        Console.WriteLine(Math.Ceiling(3.14)); /// 4
        // double ve decimal degerleri alabilir. double dondurur.

        // Floor (asagi yuvarlama)

        Console.WriteLine(Math.Floor(3.14)); /// 3

        // Round (en yakin tamsayiya yuvarlama)

        Console.WriteLine(Math.Round(3.4)); /// 3
        Console.WriteLine(Math.Round(3.5)); /// 4    // yarimi da yukari yuvarliyor
        Console.WriteLine(Math.Round(3.6)); /// 4

        // Pow (us alma islemi)

        Console.WriteLine(Math.Pow(4, 3)); /// 64

        // Sqrt (karekok alma islemi)

        Console.WriteLine(Math.Sqrt(36)); /// 6

        // Truncate (degerin tam sayi kismini elde etme)

        Console.WriteLine(Math.Truncate(71.866486)); /// 71


        char ch = Console.ReadKey(true).KeyChar;
    }
}
