using System;
using System.Collections;
using System.Collections.Generic;
namespace Koleksiyon
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.odev**********************************************
            /*
            Console.WriteLine("Lutfen 20 adet sayi giriniz!");
            ArrayList sayilar = new ArrayList();
            ArrayList asal = new ArrayList();
            ArrayList asalOlmayan = new ArrayList();

            string numString;
            int number, i = 0;
            while (i < 20)
            {
                Console.Write((i + 1) + ".sayi: ");
                numString = Console.ReadLine();
                if (!int.TryParse(numString, out number) || Convert.ToInt32(numString) < 0)
                {
                    Console.WriteLine("Lutfen numeric ve pozitif sayi girisi yapiniz");
                    continue;
                }
                if (int.TryParse(numString, out number) && Convert.ToInt32(numString) > 0)
                {
                    sayilar.Add(Convert.ToInt32(numString));
                    i++;
                }
            }

            int sayac;
            for (int j = 0; j < sayilar.Count; j++)
            {
                sayac=0;
                for (int k = 2; k < Convert.ToInt32(sayilar[j]); k++)
                {
                    if (Convert.ToInt32(sayilar[j]) % k == 0)
                    {
                        sayac++;
                    }
                }

                if (sayac == 0)
                {
                    asal.Add(Convert.ToInt32(sayilar[j]));
                }
                else
                {
                    asalOlmayan.Add(Convert.ToInt32(sayilar[j]));
                }


            }

            for (int s = 0; s < asal.Count; s++)
            {
                Console.WriteLine(asal[s]);
            }
            for (int s = 0; s < asalOlmayan.Count; s++)
            {
                Console.WriteLine(asalOlmayan[s]);
            }*/


            //2.odev******************************************
           /* Console.WriteLine("Lutfen 20 adet sayi giriniz!");
            ArrayList sayilar = new ArrayList();
            ArrayList buyuk = new ArrayList();
            ArrayList kucuk = new ArrayList();
            int buyukOrt=0, kucukOrt=0, toplamOrt=0;

            string numString;
            int number, i = 0;
            while (i < 10)
            {
                Console.Write((i + 1) + ".sayi: ");
                numString = Console.ReadLine();
                if (!int.TryParse(numString, out number) || Convert.ToInt32(numString) < 0)
                {
                    Console.WriteLine("Lutfen numeric ve pozitif sayi girisi yapiniz");
                    continue;
                }
                if (int.TryParse(numString, out number) && Convert.ToInt32(numString) > 0)
                {
                    sayilar.Add(Convert.ToInt32(numString));
                    i++;
                }
            }
            sayilar.Sort();
            
            buyuk.Add(Convert.ToInt32(sayilar[sayilar.Count-1]));
            buyuk.Add(Convert.ToInt32(sayilar[sayilar.Count-2]));
            buyuk.Add(Convert.ToInt32(sayilar[sayilar.Count-3]));

            kucuk.Add(Convert.ToInt32(sayilar[0]));
            kucuk.Add(Convert.ToInt32(sayilar[1]));
            kucuk.Add(Convert.ToInt32(sayilar[2]));

            for (int a = 0; a < 3; a++)
            {
                //Console.WriteLine(buyuk[a]);
                buyukOrt+=Convert.ToInt32(buyuk[a]);  

            }
             for (int b = 0; b < 3; b++)
            {
                //Console.WriteLine(kucuk[b]);
                kucukOrt+=Convert.ToInt32(kucuk[b]);  
            }
            toplamOrt=(buyukOrt/3)+(kucukOrt/3);
            Console.WriteLine("buyuk ortalama: "+buyukOrt/3);
            Console.WriteLine("kucuk ortalama: "+kucukOrt/3);
            Console.WriteLine("toplam ortalama: "+toplamOrt);*/

        }
    }
}
