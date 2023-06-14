namespace _15_pre_made_classes_and_functions;
class _2_dateTime
{
    static void Main2(string[] args)
    {
        // DateTime structi

        // Now (kodun calistigi anin tarih saat bilgisini dondurur)

        Console.WriteLine(DateTime.Now); /// 10.06.2023 16:27:34


        // Today (kodun calistigi anin sadece tarih bilgisini getirir)

        Console.WriteLine(DateTime.Today); /// 10.06.2023 00:00:00


        // Compare (iki tarihi kiyaslamani saglar)

        // overload: DateTime.DateTime(int year, int month, int day)

        DateTime tarih1 = new DateTime(2000, 10, 21);
        DateTime tarih2 = new DateTime(2023, 06, 10);

        int result = DateTime.Compare(tarih1, tarih2);
        // Compare 1, 0 ya da -1 seklinde int degerler dondurur.

        // ToString("dd.MM.yyyy") ile tarih ciktisinin yazilis seklini degistiriyorum.

        Console.WriteLine(result == -1 ? @$"{tarih1.ToString("dd.MM.yyyy")} daha eski bir tarih." :
        @$"{tarih1.ToString("dd.MM.yyyy")} daha yeni bir tarih.");


        // AddX (tarihe eklemede bulunmayi saglar)

        DateTime tarihFatos = new DateTime(1991, 12, 08);

        Console.WriteLine(tarihFatos.AddDays(365)); /// 1992
        Console.WriteLine(tarihFatos.AddYears(1000)); /// 2991

        // AddHours, AddSeconds..... hepsi kullanilabilir.


        // TimeSpan struct'i (tarihten tarihi cikarmayi saglar)

        DateTime dt1 = DateTime.Now;

        DateTime dt2 = new DateTime(2000, 1, 1);

        TimeSpan span = dt1 - dt2;

        Console.WriteLine(span.Days); /// 8563



        char ch = Console.ReadKey(true).KeyChar;
    }
}
