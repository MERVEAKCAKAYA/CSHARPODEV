using System;
using System.Collections;
using System.Collections.Generic;
namespace Koleksiyon
{
    class Program
    {
        static void Main(string[] args)
        {
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
            }

        }
    }
}

