using Microsoft.Extensions.Primitives;

namespace _12_data_performance_in_arrays;
class _2_stringSegment
{
    static void Main2(string[] args)
    {
        // StringSegment

        // Microsoft.Extensions.Primitives paketi eklendi.
        // using Microsoft.Extensions.Primitives;
        // kutuphane dahil edildi.

        string text = "sacma sapan konusma la";

        StringSegment segment = new StringSegment(text);
        // boyle stringin tamamini da referans edebiliriz.

        StringSegment segment1 = new StringSegment(text, 20, 2);
        // boyle belli bi kismini da referans edebiliriz.

        Console.WriteLine(segment1);



        System.Console.ReadKey();
    }
}
