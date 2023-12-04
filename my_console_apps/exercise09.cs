namespace my_console_apps;
class exercise09
{
    static void Main9(string[] args)
    {
        // Kullaniciyi bulundugu saate gore karsilayan program.

        int time = DateTime.Now.Hour;

        string sonuc = 
        time >= 6 && time < 11 ? "Gunaydin!" :
        time >= 11 && time < 17 ? "Iyi gunler!" : 
        time >= 17 && time < 22 ? "Iyi aksamlar!" : " Iyi geceler!";

        Console.WriteLine(sonuc);

        char ch = Console.ReadKey().KeyChar;
    }
}
