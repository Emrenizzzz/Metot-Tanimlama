using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metot_Tanimlama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //erisim_belirteci, geridonus_tipi, metot_adi(parametreListesi/Arguman)
            //{
            //komutlar
            //return

            //}


            int a = 3;
            int b = 4;

            Console.WriteLine(a+b);

            int sonuc = Topla(a, b);
            Console.WriteLine(sonuc);


            Metotlar ornek = new Metotlar();
            ornek.EkranaYazdir(Convert.ToString(sonuc));

            int sonuc2 = ornek.ArttirveTopla(a, b);
            Console.WriteLine(sonuc2);

            int sonuc3 = ornek.ArttirveTopla2(ref a, ref b);
            Console.WriteLine(sonuc3);
        }

        static int Topla(int deger1,int deger2)
        {
            return (deger1 + deger2);
        }
    }

    class Metotlar
    {
        public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }

        public int ArttirveTopla(int deger, int deger2)
        {
            deger += 1;
            deger2 += 1;
            return deger + deger2;
        }

        public int ArttirveTopla2(ref int deger, ref int deger2)
        {
            deger += 1;
            deger2 += 1;
            return deger + deger2;
        }
    }
}
