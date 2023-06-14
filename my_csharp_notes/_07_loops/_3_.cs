namespace _07_loops
{
    internal class _3_
    {
        static void Main3(string[] args)
        {
            //while örnek - saniye
            // o anki tarihin saniye değeri eğer 5'in katıysa, tarihi ekrana yazdıran kod.
            
            while (true)
            {
                if (DateTime.Now.Second % 5 == 0)
                    Console.WriteLine(DateTime.Now);
            }

            char ch = Console.ReadKey().KeyChar;
        }
    }
}