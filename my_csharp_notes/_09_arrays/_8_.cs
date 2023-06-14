namespace _09_arrays
{
    internal class _8_
    {
        static void Main8(string[] args)
        {
            // metot 6 - CreateInstance

            int[] yaşlar = new int[3];  // klasik.

            // overload: Array Array.CreateInstance(Type elementType, int length)
            Array yaşlar2 = Array.CreateInstance(typeof(int), 3);

            // yaşlar ve yaşlar2 dizileri aynıdır. ama farklı yollarla yaratıldılar.


            // CreateInstance ile çok boyutlu dizi yaratımı:

            // overload: Array Array.CreateInstance(Type elementType, params int[] lengths)
            // params keyword'ünü bilmiyoruz ama şunu demek istiyor:
            // yeni parametre girdikçe genişleyecek.

            Array yaşlar3 = Array.CreateInstance(typeof(int), 2, 6, 4, 56, 12, 9);

            Console.WriteLine(yaşlar3.Rank);       /// 6  (boyutlu dizi)

            char ch = Console.ReadKey().KeyChar;
        }
    }
}