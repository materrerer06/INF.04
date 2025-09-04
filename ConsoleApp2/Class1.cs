using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Class1
    {
        public int[] tablica;
        public int rozmiar=100;
        public Class1(int rozmiar_tab)
        {
            this.rozmiar = rozmiar_tab;
            tablica = new int[rozmiar];
            Random rand = new Random();
            for(int i =0; i<rozmiar;i++)
            {
                tablica[i] = rand.Next(1, 1000);
            }
        }
        public void wyswietl()
        {
            for(int i =0;i<rozmiar;i++)
            {
                Console.Write(i+": "+ tablica[i]+"\n");
            }
            Console.WriteLine();
        }
        public int szukaj(int co_szukam)
        {
            return Array.IndexOf(tablica, co_szukam);
        }
        public void np()
        {
            foreach(int x in this.niepa)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("Razem nieparysztych: " + niepa.Count());
        }

        public int[] niepa { get
        {
                return tablica.Where(e => e % 2 != 0).ToArray();
        }
        }
        public int srednia { get
        {
                return (int)tablica.Average();
        }
        }
        public int min
        {
            get
            {
                return (int)tablica.Min();
            }
        }
        public int max
        {
            get
            {
                return (int)tablica.Max();
            }
        }
    }
}
