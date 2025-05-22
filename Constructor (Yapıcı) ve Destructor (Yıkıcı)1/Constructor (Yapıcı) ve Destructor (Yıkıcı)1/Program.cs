using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor__Yapıcı__ve_Destructor__Yıkıcı_1
{
    internal class Program
    {
        class Kitap
        {
            public string Ad;
            public string Yazar;

            // Varsayılan constructor
            public Kitap()
            {
                Ad = "Bilinmiyor";
                Yazar = "Bilinmiyor";
                Console.WriteLine("Varsayılan yapıcı çalıştı.");
            }

            // Parametreli constructor
            public Kitap(string ad, string yazar)
            {
                Ad = ad;
                Yazar = yazar;
                Console.WriteLine("Parametreli yapıcı çalıştı.");
            }

            // Destructor
            ~Kitap()
            {
                Console.WriteLine("Kitap nesnesi bellekten siliniyor...");
            }

            public void Yazdir()
            {
                Console.WriteLine($"Kitap Adı: {Ad}, Yazar: {Yazar}");
            }
        }
        static void Main(string[] args)
        {
            Kitap k1 = new Kitap(); // Varsayılan constructor
            k1.Yazdir();

            Kitap k2 = new Kitap("1984", "George Orwell"); // Parametreli constructor
            k2.Yazdir();

            // Destructor, garbage collector tarafından otomatik çağrılır.
            // Elle çağrılamaz ancak uygulama kapanırken görülebilir.
        }
    }
}
