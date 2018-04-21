using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_RimskaCisla
{
    class RimskeCislo
    {
        public long Cislo{ get; set; }

        public long Zasobnik { get; set; }

        public RimskeCislo(long cislo)
        {
            Cislo = cislo;
        }

        public long PoznejM(long cislo)
        {
            long M = 1000;
            if (cislo >= M)
            {
                long zbytekM = cislo % M;
                long podilM = (cislo - zbytekM) / M;
                Zasobnik = zbytekM;
                return podilM;
            }
            else
            {
                Zasobnik = cislo;
                //return cislo;
                return 0;
            }
        }

        public long PoznejD(long cislo)
        {
            long D = 500;
            if (cislo >= D)
            {
                long zbytekD = cislo % D;
                long podilD = (cislo - zbytekD) / D;
                Zasobnik = zbytekD;
                return podilD;
            }
            else
            {
                Zasobnik = cislo;
                //return cislo;
                return 0;
            }
        }

        public long PoznejC(long cislo)
        {
            long C = 100;
            if (cislo >= C)
            {
                long zbytekC = cislo % C;
                long podilC = (cislo - zbytekC) / C;
                Zasobnik = zbytekC;
                return podilC;
            }
            else
            {
                Zasobnik = cislo;
                return 0;
            }
        }

        public long PoznejL(long cislo)
        {
            long L = 50;
            if (cislo >= L)
            {
                long zbytekL = cislo % L;
                long podilL = (cislo - zbytekL) / L;
                Zasobnik = zbytekL;
                return podilL;
            }
            else
            {
                Zasobnik = cislo;
                return 0;
            }
        }

        public long PoznejX(long cislo)
        {
            long X = 10;
            if (cislo >= X)
            {
                long zbytekX = cislo % X;
                long podilX = (cislo - zbytekX) / X;
                Zasobnik = zbytekX;
                return podilX;
            }
            else
            {
                Zasobnik = cislo;
                //return cislo;
                return 0;
            }
        }

        public long PoznejV(long cislo)
        {
            long V = 5;
            if (cislo >= V)
            {
                long zbytekV = cislo % V;
                long podilV = (cislo - zbytekV) / V;
                Zasobnik = zbytekV;
                return podilV;
            }
            else
            {
                Zasobnik = cislo;
                return 0;
            }
        }

        public long PoznejI(long cislo)
        {
            long I = 1;
            if (cislo >= I)
            {
                return cislo;
            }
            else
            {
                return 0;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //pracovní plocha projektu
            long cislo;
            string rimskeCislo = "";
            bool finish = false;
            while (finish != true)
            {
                Console.Clear();
                Console.WriteLine("Zadej cislo, ktere chces prevest:");
                cislo = long.Parse(Console.ReadLine());
                if(cislo < 0)
                {
                    finish = true;
                    goto konec;
                }
                RimskeCislo c1 = new RimskeCislo(cislo);
                Console.WriteLine($"Pro kontrolu: zadane cislo je {cislo} (ve tride je zapsano {c1.Cislo})");
                Console.WriteLine();
                Console.ReadKey();

                Console.WriteLine("Informacni system programu:");
                Console.WriteLine();
                if (c1.PoznejM(cislo) != cislo)
                {
                    Console.WriteLine($"Pocet vypsani M je: {c1.PoznejM(cislo)}");
                }
                else
                {
                    Console.WriteLine("Pocet vypsani M je: 0");
                }

                if (c1.PoznejD(cislo) != cislo)
                {
                    Console.WriteLine($"Pocet vypsani D je: {c1.PoznejD(cislo)}");
                }
                else
                {
                    Console.WriteLine("Pocet vypsani D je: 0");
                }

                if (c1.PoznejC(cislo) != cislo)
                {
                    Console.WriteLine($"Pocet vypsani C je: {c1.PoznejC(cislo)}");
                }
                else
                {
                    Console.WriteLine("Pocet vypsani C je: 0");
                }

                if (c1.PoznejL(cislo) != cislo)
                {
                    Console.WriteLine($"Pocet vypsani L je: {c1.PoznejL(cislo)}");
                }
                else
                {
                    Console.WriteLine("Pocet vypsani L je: 0");
                }

                if (c1.PoznejX(cislo) != cislo)
                {
                    Console.WriteLine($"Pocet vypsani X je: {c1.PoznejX(cislo)}");
                }
                else
                {
                    Console.WriteLine("Pocet vypsani X je: 0");
                }

                if (c1.PoznejV(cislo) != cislo)
                {
                    Console.WriteLine($"Pocet vypsani V je: {c1.PoznejV(cislo)}");
                }
                else
                {
                    Console.WriteLine("Pocet vypsani V je: 0");
                }

                Console.WriteLine($"Pocet vypsani I je: {c1.PoznejI(cislo)}");

                Console.WriteLine();

                //fáze parsování do výsledného řetězce
                char[] M = new char[c1.PoznejM(cislo)];
                for (long m = 0; m < c1.PoznejM(cislo); m++)
                {
                    M[m] = 'M';
                    rimskeCislo = string.Join("", M[m]);
                }
                string VypisM = new string(M);
                Console.WriteLine($"M string: {VypisM}");
                cislo = c1.Zasobnik;
                Console.WriteLine($"Zasobnik po M: {c1.Zasobnik}");
                //Console.WriteLine($"Pocet znaku po M: {pocetZnaku}");

                char[] D = new char[c1.PoznejD(cislo)];
                for (long d = 0; d < c1.PoznejD(cislo); d++)
                {
                    D[d] = 'D';
                    rimskeCislo = string.Join("", D[d]);
                }
                string VypisD = new string(D);
                Console.WriteLine($"D string: {VypisD}");
                cislo = c1.Zasobnik;
                Console.WriteLine($"Zasobnik po D: {c1.Zasobnik}");
                //Console.WriteLine($"Pocet znaku po D: {pocetZnaku}");

                char[] C = new char[c1.PoznejC(cislo)];
                for (long c = 0; c < c1.PoznejC(cislo); c++)
                {
                    C[c] = 'C';
                    rimskeCislo = string.Join("", C[c]);
                }
                string VypisC = new string(C);
                Console.WriteLine($"C string: {VypisC}");
                cislo = c1.Zasobnik;
                Console.WriteLine($"Zasobnik po C: {c1.Zasobnik}");

                char[] L = new char[c1.PoznejL(cislo)];
                for (long l = 0; l < c1.PoznejL(cislo); l++)
                {
                    L[l] = 'L';
                    rimskeCislo = string.Join("", L[l]);
                }
                string VypisL = new string(L);
                Console.WriteLine($"L string: {VypisL}");
                cislo = c1.Zasobnik;
                Console.WriteLine($"Zasobnik po L: {c1.Zasobnik}");

                char[] X = new char[c1.PoznejX(cislo)];
                for (long x = 0; x < c1.PoznejX(cislo); x++)
                {
                    X[x] = 'X';
                    rimskeCislo = string.Join("", X[x]);
                }
                string VypisX = new string(X);
                Console.WriteLine($"X string: {VypisX}");
                cislo = c1.Zasobnik;
                Console.WriteLine($"Zasobnik po X: {c1.Zasobnik}");
                //Console.WriteLine($"Pocet znaku po X: {pocetZnaku}");

                char[] V = new char[c1.PoznejV(cislo)];
                for (long v = 0; v < c1.PoznejV(cislo); v++)
                {
                    V[v] = 'V';
                    rimskeCislo = string.Join("", V[v]);
                }
                string VypisV = new string(V);
                Console.WriteLine($"V string: {VypisV}");
                cislo = c1.Zasobnik;
                Console.WriteLine($"Zasobnik po V: {c1.Zasobnik}");


                char[] I = new char[c1.PoznejI(cislo)];
                for (long i = 0; i < c1.PoznejI(cislo); i++)
                {
                    I[i] = 'I';
                    rimskeCislo = string.Join("", I[i]);
                }
                string VypisI = new string(I);
                Console.WriteLine($"I string: {VypisI}");
                cislo = c1.Zasobnik;
                Console.WriteLine($"Zasobnik po I: {c1.Zasobnik}");
                Console.WriteLine();
                
                Console.WriteLine($"Tvar vysledneho retezce: {VypisM}{VypisD}{VypisC}{VypisL}{VypisX}{VypisV}{VypisI}");
                Console.ReadKey();
            }

            konec:

            Console.Clear();
            Console.WriteLine("Konec testovani...");
            Console.ReadKey();
            System.Environment.Exit(1);
        }
    }
}
