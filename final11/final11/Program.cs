using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final11
{
    class Dizi
    {
        private int[] elemanlar;

        public Dizi()
        {
            elemanlar = new int[9];
            Random rastgele = new Random();

            for (int i = 0; i < 9; i++)
            {
                int yeniEleman;
                do
                {
                    yeniEleman = rastgele.Next(0, 100);
                } while (Array.IndexOf(elemanlar, yeniEleman) != -1);

                elemanlar[i] = yeniEleman;
            }
        }

        public void Yazdir()
        {
            Console.WriteLine("Dizi Elemanları:");
            foreach (int eleman in elemanlar)
            {
                Console.Write(eleman + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Sıralı Dizi Elemanları:");
            int[] siraliElemanlar = (int[])elemanlar.Clone();
            Array.Sort(siraliElemanlar);
            foreach (int eleman in siraliElemanlar)
            {
                Console.Write(eleman + " ");
            }
            Console.WriteLine();
        }

        public int Medyan()
        {
            int[] siraliElemanlar = (int[])elemanlar.Clone();
            Array.Sort(siraliElemanlar);
            int ortaIndex = siraliElemanlar.Length / 2;
            return siraliElemanlar[ortaIndex];
        }

        public static bool operator >(Dizi a, Dizi b)
        {
            return a.Medyan() > b.Medyan();
        }

        public static bool operator <(Dizi a, Dizi b)
        {
            return a.Medyan() < b.Medyan();
        }
    }

    class Program
    {
        static void Main()
        {
            Dizi a = new Dizi();
            Dizi b = new Dizi();

            Console.WriteLine("Dizi A:");
            a.Yazdir();
            Console.WriteLine("Dizi A Medyan Değeri: " + (int)a.Medyan());

            Console.WriteLine();

            Console.WriteLine("Dizi B:");
            b.Yazdir();
            Console.WriteLine("Dizi B Medyan Değeri: " + (int)b.Medyan());

            Console.WriteLine();

            bool sonuc = a > b;
            if (sonuc)
            {
                Console.WriteLine("Dizi A'nın medyan değeri daha büyük.");
            }
            else
            {
                Console.WriteLine("Dizi B'nin medyan değeri daha büyük.");
            }
        }
    }
}
