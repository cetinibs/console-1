using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            int iToplam = 0, iSayi, İSayac = 0;
            while (iToplam < 500)
            {
                Console.Write("Sayı giriniz:");
                iSayi = Convert.ToInt32(Console.ReadLine());
                iToplam += iSayi;
                İSayac++;
            }

            Console.WriteLine("{0} adet sayı girişi yaptınız. Girilen sayıların toplamı={1}", İSayac, iToplam);
            Console.ReadKey();

        }
    }
}
