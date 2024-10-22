using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaziFeladat_c_2024._10._22
{
    internal class Program
    {
        class Konyv
        {
            private string Cim { get; set; }
            private string Szerzo { get; set; }
            private int Oldalszam { get; set; }
            private double Ar { get; set; }


            public Konyv(string cim, string szerzo, int oldalszam, double ar)
            {
                Cim = cim;
                Szerzo = szerzo;
                Oldalszam = oldalszam;
                Ar = ar;
            }

            public Konyv(string cim, string szerzo, int oldalszam)
            {
                Cim = cim;
                Szerzo = szerzo;
                Oldalszam = oldalszam;
                Ar = 3000;
            }



            public override string ToString()
            {
                return $"A könyv szerzője{Szerzo}, a cime{Cim}, az oldalszama {Oldalszam},az ára{Ar}";
            }
            public void Vastage()
            {
                if (Oldalszam > 500)
                {
                    Console.WriteLine("A könyved 500 oldalnál is több");
                }

                else
                {
                    Console.WriteLine("Konyved nem tobb mint 500 oldal");
                }
            }
            public void Dragae()
            {
                if (Ar > 5000)
                {
                    Console.WriteLine("Draga");


                }
                else
                {
                    Console.WriteLine("Nem draga");
                }








            }

            static void Main(string[] args)
            {
                Console.WriteLine("Hany konyvet szeretnel ");
                int Konyvekszam = Convert.ToInt32(Console.ReadLine());

                List<Konyv> list = new List<Konyv>();

                for (int i = 0; i < Konyvekszam; i++)
                {
                    Console.WriteLine($"{i + 1}");
                    Console.WriteLine("Adj meg a cimet");
                    string cim = Console.ReadLine();

                    Console.WriteLine("Add meg a szerzot");
                    string szerzo = Console.ReadLine();

                    Console.WriteLine("Add meg az oldal szamat");
                    int oldalszam = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Add meg az arat");
                    int ar = Convert.ToInt32(Console.ReadLine());

                    Konyv konyvek = new Konyv(cim, szerzo, oldalszam, ar);
                    list.Add(konyvek);

                    Console.WriteLine(list.Count);


                }



                foreach (Konyv konyv in list)
                {
                    Console.WriteLine(konyv.ToString());
                    konyv.Vastage();
                    konyv.Dragae();



                }


                Console.ReadKey();
            }
        }
    }
}


      
    

