namespace _9_arrays
{
    internal class _1_
    {
        static void Main1(string[] args)
        {
            // arrays

            // dizi - örnek 1

            int yaş;    // bir değişken

            int[] yaşlar = new int[10];   // on elemanlı bir dizi

            yaşlar[5] = 55;
            yaşlar[2] = 22;

            Console.WriteLine(yaşlar[5]);
            Console.WriteLine(yaşlar[2]);
            Console.WriteLine(yaşlar[8]);

            //////////////////////////////////
            
            // dizi - örnek 2

            string[] işçiler = new string[10];

            işçiler[0] = "Oğuzhan";
            işçiler[1] = "Ramazan";
            işçiler[2] = "Kaan";
            işçiler[3] = "Mami";
            işçiler[4] = "Ahmet";
            işçiler[5] = "Emre";
            işçiler[6] = "Mehmet";
            işçiler[7] = "Numan";
            işçiler[8] = "Şamil";
            işçiler[9] = "Beyjan";

            for (int i = 0; i < işçiler.Length; i++)
            {
                Console.WriteLine(işçiler[i]);
            }

            char ch = Console.ReadKey().KeyChar;
        }
    }
}