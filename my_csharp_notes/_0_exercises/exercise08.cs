namespace _0_exercises
{
    internal class exercise08
    {
        static void Main8(string[] args)
        {
            //18 karakterli, harflerden olusan sifre yaratan program.
            
            Random rnd = new Random();

            string harfler = "qwertyuopasdfghjklizxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM";
            string sifre = string.Empty;

            for (int i = 0; i < 18; i++)
            {
                sifre += harfler[rnd.Next(harfler.Length)];
            }

            Console.WriteLine(sifre);

            char ch = Console.ReadKey(true).KeyChar;
        }
    }
}