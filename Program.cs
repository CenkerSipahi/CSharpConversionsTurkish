using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tip_Dönüşümleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Implicit Conversion (Bilinçsiz Dönüşüm) :
            // Bir değişkenin kendinden daha büyük kapasiteli değişkene atanmasıdır

            // Örnek :
            Console.WriteLine("**** Implicit Conversion Örnekleri ****");
            Console.WriteLine("");
                byte a = 7;             // byte 0 ile 255 arası değer alır.
                int b = a;              // integer (int) daha büyük değer alabildiği için byte olan a değişkenini değeri olarak kabul edebilir.
                Console.WriteLine(b);   // Çıktısı 7.

                char c = 'x';
                string d = "Cenker Sipahi";
                int e = 2022;
                object f = d + c + e;   // Object değişkeni tüm veri tiplerinden üstün olduğu için her şeyi ona çevirebiliriz.
                Console.WriteLine("{0}", f);   // Çıktısı Cenker Sipahix2022
            Console.WriteLine("");
            Console.WriteLine("**** Implicit Conversion Örnekleri ****");
            Console.WriteLine("");
            // Kısaca bu dönüşüm sadece küçük değişkenden büyük değişkene doğru program tarafından otomatik olarak yapılır.
            // Büyük değişkenden küçük değişkene bu şekilde atamalarda hata oluşur.

            // Explicit Conversion (Bilinçli Dönüşüm) :
            // C#'ın kendi yapamadığı, programcının kendi yazmasıyla yaptığı dönüşümler.
            // Convert.To[veritipi](), (veritipi)[değişken] şeklinde dönüştürülebilir.
            // [değişken].ToString() bir veriyi string verisine çevirir.
            // [veritipi].Parse(değişken) string ifadeleri dönüştürmek için kullanılır.
            // Bu çevirilerde veri kaybı olabilir.
            Console.WriteLine("**** Explicit Conversion Örnekleri ****");
            Console.WriteLine("");
                // (veritipi)[değişken] Örneği.
                int g = 14;
                byte h = (byte)g;       // Normalde integer'ı byte verisine çeviremeyiz, ama bu şekilde yapıldığında çevirebiliriz.
                Console.WriteLine("(veritipi)[değişken] Örneği : {0}", h);

                double i = 3.14;        // Veri kaybı örneği bu şekildedir, double küsürlü sayıları tutan bir veri ancak int olmadığı için...
                int l = (int)i;         // 3.14 sayısını 3'e yuvarlıyor ve o şekilde kaydediyor.      
                Console.WriteLine("(veritipi)[değişken] Örneği : {0}", l);

                //[değişken].ToString() Örneği.
                int q = 795;
                string p = q.ToString();// p'nin değeri string türünden 795 oluyor.
                Console.WriteLine("[değişken].ToString() Örneği : {0}", p);

                //Convert.To[veritipi]() Örneği.
                string n1 = "10", n2 = "14";
                int num1, num2, toplam;
                num1 = Convert.ToInt32(n1); // string olan n1 değerini Int32'ye çeviriyor ve num1'e kaydediyor.
                num2 = Convert.ToInt32(n2); // string olan n2 değerini Int32'ye çeviriyor ve num2'ye kaydediyor.
                toplam = num1 + num2;       // Toplam sonucu 24.
                Console.WriteLine("Convert.To[veritipi](veri) Örneği : {0}", toplam);

                //[veritipi].Parse(değişken) Örneği.
                string t1 = "24", t2 = "1,3";
                int s1;
                double s2;

                s1 = Int32.Parse(t1);   // String olan t1'i Int32'ye çevirip s1'e kaydediyor.
                s2 = Double.Parse(t2);  // String olan t2'i Double'a çevirip s2'ye kaydediyor.

                Console.WriteLine("1. [veritipi].Parse(değişken) Örneği : {0}", s1);
                Console.WriteLine("2. [veritipi].Parse(değişken) Örneği : {0}", s2);


            Console.WriteLine("");
            Console.WriteLine("**** Explicit Conversion Örnekleri ****");
        }
    }
}
