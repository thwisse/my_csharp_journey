namespace _16_methods;

class _3_recursive_methods
{
    static void Main3(string[] args)
    {
        X();

        void X(int a = 1)   // local function
        {
            Console.WriteLine("Merhaba");
            if (a < 3)
            {
                X(++a);
            }
        }

        char ch = Console.ReadKey(true).KeyChar;
    }
}
