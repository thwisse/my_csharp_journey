namespace _0_exercises
{
    internal class exercise1
    {
        static void Main1(string[] args)
        {
            //Yaricapi girilen kurenin alanini ve hacmini bulan program.
            
            double yaricap, alan, hacim;

            const double pi = 3.14;

            Console.Write("Kurenin yaricapini giriniz: ");

            yaricap = Convert.ToDouble(Console.ReadLine());

            alan = 4 * pi * yaricap * yaricap;

            hacim = (4 * pi * yaricap * yaricap * yaricap) / 3;

            Console.WriteLine("Yaricapi {0} olan kurenin alani: {1} - hacmi: {2}", 
            yaricap, alan, hacim);

            char ch = Console.ReadKey(true).KeyChar;
        }
    }
}