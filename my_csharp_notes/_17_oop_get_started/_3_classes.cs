namespace _17_oop_get_started
{
    class _3_classes
    {
        static void Main(string[] args)
        {
            Ataturk a = new Ataturk();

            Ataturk.Inonu b = new Ataturk.Inonu();

            a.mustafakemal = "gazi";
            a.metot("xd");
            a.metot(5);

            char ch = Console.ReadKey().KeyChar;
        }
    }

    /// <summary>
    /// Ataturk hakkinda aciklama.
    /// </summary>
    class Ataturk
    {
        public string mustafakemal { get; set; }

        /// <summary>
        /// Inonu hakkinda aciklama.
        /// </summary>
        public class Inonu
        {
            string ismet;
        }

        /// <summary>
        /// Ornek metot overloadi 1
        /// </summary>
        /// <param name="x">bu x parametresini aliyor.</param>
        public void metot(string x)
        {

        }
        /// <summary>
        /// Ornek metot overloadi 2
        /// </summary>
        /// <param name="y">bu y parametresini aliyor.</param>
        public void metot(int y)
        {

        }
    }
}