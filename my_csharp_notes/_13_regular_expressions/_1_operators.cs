using System.Text.RegularExpressions;

namespace _13_regular_expressions;
class _1_operators
{
    static void Main(string[] args)
    {
        // ^ operatoru

        string text = ("98342uf5cv823, ['pq3o =23940ut");

        // using System.Text.RegularExpressions;

        Regex regex1_1 = new Regex("^9");
        Match match1_1 = regex1_1.Match(text);

        Console.WriteLine(match1_1.Success); /// True
        // string belirtilen ifadeyle basliyorsa True, baslamiyorsa False donecek

        Regex regex1_2 = new Regex("^98");
        Match match1_2 = regex1_2.Match(text);

        Console.WriteLine(match1_2.Success); /// True

        // \ operatoru

        string text2 = ("Z8 ");

        Regex regex2_1 = new Regex(@"^Z\w\s"); 
        // Z ile baslasin. sonra alfanumerik karakter gelsin. sonra bosluk gelsin.
        // "" icinde \ kullanilamadigi icin verbatim strings ozelliginden @ faydalandik.
        Match match2_1 = regex2_1.Match(text2);

        Console.WriteLine(match2_1.Success); /// True

        // konuyu burada biraktim. daha sonra devam edecegim.
        


        char ch = Console.ReadKey(true).KeyChar;
    }
}
