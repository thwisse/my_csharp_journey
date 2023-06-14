namespace _07_loops
{
    internal class _2_
    {
        static void Main2(string[] args)
        {
            // while örnek - geri sayım

            Console.Write("Sayı girin: ");
            int sayı = int.Parse(Console.ReadLine());
            int i = sayı;

            while (i >= 0)
            {   
                Console.WriteLine(i);
                i--;
            }

            char ch = Console.ReadKey().KeyChar;
        }
    }
}