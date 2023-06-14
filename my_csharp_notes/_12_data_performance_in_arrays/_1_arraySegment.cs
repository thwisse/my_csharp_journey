namespace _12_data_performance_in_arrays;
class _1_arraySegment
{
    static void Main1(string[] args)
    {
        int[] sayilar = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };

        int[] sayilar_ = sayilar[2..5];
        // ranges and indicies ozelligi ile ilk dizinin 3 elemanini kopyaladim.
        // evet kopyaladim, referans etmedim.
        // 2. indexten basla. 5. indexe kadar. 5 dahil degil.

        sayilar_[0] = 300;
        // ilk diziye etki etmez. baska bir dizinin elemanini degistirdim.

        // overload 2: ArraySegment<int>.ArraySegment(int[] array)
        ArraySegment<int> segment_s = new ArraySegment<int>(sayilar);
        // dizinin tum elemanlarini referans eder.

        segment_s[2] = 300;
        // ilk dizinin 2. indexine referans verdim. 30'u 300 yaptim.

        // overload 3: ArraySegment<int>.ArraySegment(int[] array, int offset, int count)
        ArraySegment<int> segment_s2 = new ArraySegment<int>(sayilar, 2, 5);
        // 5 count kadar 2. indexten itibaren referans eder. (bu dizide 30, 40 ve 50 degerleri)

        segment_s2[0] = 3000;
        // yine ilk dizinin 2. indexine referans verdim. bu sefer 300'u 3000 yaptim.

        // Slicing

        int[] rakamlar = { 1, 2, 3, 4, 5, 6, 7, 8, 9 }; // 0 haric :d

        ArraySegment<int> segment = new ArraySegment<int>(rakamlar);

        ArraySegment<int> segment1 = segment.Slice(0, 3);
        ArraySegment<int> segment2 = segment.Slice(3, 3);
        ArraySegment<int> segment3 = segment.Slice(6, 3);

        // slice metodunun ilk parametresi, dizideki baslangic indeksidir. 
        // ikinci parametre ise bu baslangic indeksinden itibaren alinacak eleman sayisini belirtir.

        for (int i = 0; i < segment1.Count; i++)
        {
            Console.WriteLine(segment1[i]);
        }
        Console.WriteLine("-------");

        for (int i = 0; i < segment2.Count; i++)
        {
            Console.WriteLine(segment2[i]);
        }
        Console.WriteLine("-------");

        for (int i = 0; i < segment3.Count; i++)
        {
            Console.WriteLine(segment3[i]);
        }

        System.Console.ReadKey();
    }
}
