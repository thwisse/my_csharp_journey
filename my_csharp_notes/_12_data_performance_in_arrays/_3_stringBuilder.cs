using Microsoft.Extensions.Primitives;
using System.Text;

namespace _12_data_performance_in_arrays;

class _3_stringBuilder
{
    static void Main3(string[] args)
    {
        // using Microsoft.Extensions.Primitives;   (StringSegment icin.)
        // using System.Text;   (StringBuilder icin) 
        // StringBuilder arkaplanda StringSegment kullanir.

        string a1 = "Alejandro";
        string a2 = "Gomez";
        string a3 = "Arias";
        string a4 = "Hose";
        string a5 = "Lobredo";
        string a6 = "Alfonzo";
        string a7 = "Villa";
        string a8 = "de Santos";

        StringBuilder builder = new StringBuilder();

        builder.Append(a1);
        builder.Append(" ");
        builder.Append(a2);
        builder.Append(" ");
        builder.Append(a3);
        builder.Append(" ");
        builder.Append(a4);
        builder.Append(" ");
        builder.Append(a5);
        builder.Append(" ");
        builder.Append(a6);
        builder.Append(" ");
        builder.Append(a7);
        builder.Append(" ");
        builder.Append(a8);
        builder.Append(" ");


        Console.WriteLine(builder.ToString());

        System.Console.ReadKey();
    }
}