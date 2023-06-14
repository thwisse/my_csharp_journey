namespace _07_loops
{
    internal class _1_
    {
        static void Main1(string[] args)
        {
            //for örnek - faktöriyel bulma

            Console.Write("Sayıyı girin: ");
            int sayı = int.Parse(Console.ReadLine());

            // çözüm 1
            int faktöriyel = 1;

            for (int i = 1; i <= sayı; i++)
            {
                faktöriyel *= i;
            }
            Console.WriteLine("Faktöriyel: " + faktöriyel);

            // çözüm 2 ve bazı eklemeler
            int faktöriyell = 1;
            string sonuç = "";

            for (int i = sayı; i > 0; i--)
            {
                faktöriyell *= i;
                sonuç += i + (i == 1 ? " = " : " * ");  // ternary'ye can kurban
            }
            Console.WriteLine("Faktöriyel: " + sonuç + faktöriyell);

            char ch = Console.ReadKey().KeyChar;
        }
    }
}