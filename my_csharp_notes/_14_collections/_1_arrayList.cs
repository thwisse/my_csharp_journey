using System.Collections;

namespace _14_collections;
class _1_arrayList
{
    static void Main1(string[] args)
    {
        int[] numbers = new int[100]; // dizinin boyutunu belirlememiz gerekiyor

        // using System.Collections;

        ArrayList _numbers = new ArrayList(); // boyutu belirlememize gerek yok.

        numbers[5] = 1453;  // alani bizim belirlememiz gerekiyor

        Console.WriteLine(numbers[5]);  /// 1453

        _numbers.Add(1453); // siradaki bos alana veriyi yerlestirecek. her veriyi sirayla ekleyecek.

        Console.WriteLine(_numbers[0]); /// 1453   // ilk veriyi ilk indexe atmis.

        for (int i = 0; i < 10; i++)
        {
            numbers[i] = i + 1;

            _numbers.Add(i + 1);
        }

        Console.WriteLine("---------");

        for (int i = 0; i < 11; i++) // _numbers.Length falan yapamiyoruz. o yuzden simdilik boyle yaptik.
            Console.WriteLine(_numbers[i]);

        // 0. indexte 1453 var. 1den 10. indexe kadar 1den 10a kadar olan sayilar var.

        Console.WriteLine("---------");

        Console.WriteLine(_numbers.Count); // bu property ile koleksiyonun eleman sayisi ogrenilir

        _numbers.Remove(1453); // 1453 objesini sildim

        //////// koleksiyondaki verilerle bi islem yapalim.

        Console.WriteLine("---------");

        for (int i = 0; i < _numbers.Count; i++) // .Length yerine .Count kullanalim
        {
            Console.WriteLine(_numbers[i]);
        }

        Console.WriteLine("---------");

        int toplam = 0;

        for (int i = 0; i < _numbers.Count; i++)
        {
            // toplam += _numbers[i]; // elbette bu calismiyor. cunku _numbers objeleri tutuyor.

            toplam += (int)_numbers[i]; // integer'a cast ettigimizde islemi yapabiliriz.

            // (int) yerine as operatoru de kullanilabilirdi. (nullable mevzusu)
        }

        Console.WriteLine(toplam);  /// 55

        Console.WriteLine("---------");

        //////////// ArrayList Collection Initializer (Koleksiyon Ilklendirici) ile deger ekleme

        char qwerty = 'q';

        ArrayList biseyler = new ArrayList()
        {
            "Dolapdereli Sabri",
            1364,
            qwerty,
            "1364",
            false
        };

        for (int i = 0; i < biseyler.Count; i++) // .Length yerine .Count kullaniyormusuz
        {
            Console.WriteLine(biseyler[i]);
        }

        Console.WriteLine("---------");

        // farkli turde degerler tutan koleksiyona islem yaptiralim

        biseyler.Add(10);
        biseyler.Add(20);
        biseyler.Add(30);

        int toplam2 = 0;

        for (int i = 0; i < biseyler.Count; i++)
        {
            if (biseyler[i] is int) // obje int ise bu islemi yap dedik.
            {
                toplam2 += (int)biseyler[i];

                // bu sayede yalnizca 1364 ve 10,20,30 sayilarini secip toplayacak. (1424 yapmali)
            }
        }

        Console.WriteLine(toplam2); /// 1424
        

        Console.ReadKey();
    }
}
