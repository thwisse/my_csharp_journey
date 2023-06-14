namespace _12_data_performance_in_arrays;

class _4_span
{
    static void Main4(string[] args)
    {
        int[] sayilar = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };

        Span<int> span = new Span<int>(sayilar);
        Span<int> span2 = sayilar;
        // bu ikisi de ayni seydir.

        Span<int> span3 = new Span<int>(sayilar, 3, 5);
        // overload: Span<int>(int[]? array, int start, int length)

        Span<int> span4 = sayilar.AsSpan();
        Span<int> span5 = sayilar.AsSpan(3, 5);

        string text = "Na na na na na selana selana";
        ReadOnlySpan<char> readOnlySpan = text.AsSpan();
        ReadOnlySpan<char> span6 = text;

        // metinsellerde Span degil ReadOnlySpan kullanmalisin.



        System.Console.ReadKey();
    }
}