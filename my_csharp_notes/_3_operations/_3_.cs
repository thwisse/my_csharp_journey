namespace _3_operations
{
    internal class _3_
    {
        static void Main3(string[] args)
        {
            ////////////////////////////////////////////

            // member access operatörü

            int k = 5;

            Console.WriteLine(k.ToString());

            //////////////////////////////////////////////////

            // typeof operatörü

            Type t = typeof(int); 
            // int türüne ait tüm bilgiler burada t değişkenine atandı.
            // (Type t) referans türlü bir değişkendir. sonra göreceğiz

            Console.WriteLine(t.Name);          // int = Int32
            Console.WriteLine(t.IsPrimitive);   // evet int primitive'dir
            Console.WriteLine(t.IsClass);       // no
            Console.WriteLine(t.IsValueType);   // evet int value typedir

            //////////////////////////////

            // default operatörü

            Console.WriteLine(default(decimal));    // 0
            Console.WriteLine(default(string));     // null
            Console.WriteLine(default(Program));    // null
            Console.WriteLine(default(char));       // \0
            Console.WriteLine(default(bool));       // false
            Console.WriteLine(default(int));        // 0

            ///////////////////////////////////

            // is operatörü

            object name = "Oğuzhan";

            Console.WriteLine(name is bool);
            Console.WriteLine(name is decimal);
            Console.WriteLine(name is string);

            // is null operatörü

            string nick = "thwisse";

            Console.WriteLine(nick is null);    /// false

            // is not null

            Console.WriteLine(nick is not null); /// true

            

            /////////////////////////////////////////////

            // as operatörü (unboxing işlemi için cast'e nullable'larda alternatif)

            object x = "tutucu";

            // önce casting deneyelim:
            //int y = (int)x; // unnullable old. için izin vermedi
            //Program y = (Program)x; 
            // nullable olsa bile cast op bunu yapamıyor

            // şimdi as op deneyelim

            //int y = x as int; // unnullable old için olmuyor.

            //string y = x as string;   // aynı tür old için sıkıntı olmuyor zaten.     

            Program y = x as Program;

            Console.WriteLine(y);   // null dönüyor

            
            ///////////////////////////////////////////////

            // nullable (?) operatörü:

            int? r = null;

            Console.WriteLine(r is null);   // true

            // nullable ve as örneği

            object s = 123;

            int? s2 = s as int?;    // işte şimdi izin veriyor.  s2 = 123 oldu

            /////////////////////////////////////////////////////////////

            // null-coalescing (??) operatörü

            string ş = "vscode";
            string ş2 = null;

            Console.WriteLine(ş ?? "vs");   // vscode döndü
            // ş null değilse değerini döndür, eğer null ise bunu döndür diyor

            Console.WriteLine(ş2 ?? "vs");  // vs döndü
            
            /////////////////////////////////////////////////

            // null-coalescing assignment operatörü

            string j = "Arif Işık";

            string j2 = null;

            Console.WriteLine(j ??= "Cem Yılmaz");  // arif ışık

            Console.WriteLine(j2);      // null

            Console.WriteLine(j2 ??= "Cem Yılmaz"); // cem yılmaz

            Console.WriteLine(j2);  // cem yılmaz
            
            System.Console.ReadKey();
        }
    }
}