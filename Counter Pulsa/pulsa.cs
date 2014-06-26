using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Counter_Pulsa
{
    class pulsa
    {
        public int pulsaDibeli;
        public int pulsaJual;
        public int hargaPulsa = 0;
        public int laba = 0;
        public string hp { get; set; }
        public jenisPulsa jenispulsa { get; set; }
        bool cek1 = true;

        public enum jenisPulsa
        {
            nol, AS, SIMPATI, XL, IM3, MENTARI, AXIS
        }


        public pulsa()
        {
            do
            {

                Console.SetCursorPosition(5, 17); Console.Write("Jenis pulsa yang dibeli : ");
                jenispulsa = (jenisPulsa)int.Parse(Console.ReadLine());
            } while ((int)jenispulsa  > 7 && (int)jenispulsa > 0);
            if ((int)jenispulsa == 0)
            {
                cek1 = false;
            }

            else
            {
                do
                {
                    
                    Console.WriteLine();
                    Console.Write("\tMasukkan Nomor HP : ");
                    hp = Console.ReadLine();
                    if (hp.Length <= 9 || hp.Length >= 13 || hp == null)
                    {
                        Console.WriteLine("\tNomor HP error, Periksa Nomor HP");
                    }
                } while (hp.Length <= 9 || hp.Length >= 13 || hp == null);
                
                    do
                    {

                        Console.WriteLine();
                        Console.Write("\tNominal Pulsa : ");
                        pulsaDibeli = Convert.ToInt32(Console.ReadLine());
                        if (pulsaDibeli != 5000 && pulsaDibeli != 10000 && pulsaDibeli != 20000
                        && pulsaDibeli != 50000 && pulsaDibeli != 100000)
                        {
                            Console.WriteLine("\tPulsa tidak tersedia !");
                            Console.WriteLine("\tHanya tersedia pulsa 5000, 10000, 20000, 50000, 100000");

                        }
                    } while (pulsaDibeli != 5000 && pulsaDibeli != 10000 && pulsaDibeli != 20000
                        && pulsaDibeli != 50000 && pulsaDibeli != 100000);

                    

                        if (pulsaDibeli <= 25000)
                        { pulsaJual = pulsaDibeli + 1000; }
                        else 
                        { pulsaJual = pulsaDibeli + 500; }

                        if ((int)jenispulsa == 1)
                        {
                            hargaPulsa = pulsaJual;
                        }
                        else if ((int)jenispulsa == 2)
                        {
                            hargaPulsa = pulsaJual + 500;
                        }
                        else if ((int)jenispulsa == 3)
                        {
                            hargaPulsa = pulsaJual + 500;
                        }
                        else if ((int)jenispulsa == 4)
                        {
                            hargaPulsa = pulsaJual + 500;
                        }
                        else if ((int)jenispulsa == 5)
                        {
                            hargaPulsa = pulsaJual + 500;
                        }
                        else if ((int)jenispulsa == 6)
                        {
                            hargaPulsa = pulsaJual + 500;
                        }
                        
                        Console.WriteLine("\tharga jual    : {0} IDR",
                                         hargaPulsa.ToString());
                        Console.WriteLine("\nPengisian Pulsa berhasil silakan dengan nomor hp {0}", hp);
                        Console.WriteLine("\n----------------------------------------------------");
                    
                
            }
        }

        public void detailpulsa()
        {
            if ((int)jenispulsa != 1 && (int)jenispulsa != 2 && (int)jenispulsa != 3 && (int)jenispulsa != 4 && (int)jenispulsa != 5
                && (int)jenispulsa != 6 || pulsaDibeli != 5000 && pulsaDibeli != 10000 && pulsaDibeli != 20000
                        && pulsaDibeli != 50000 && pulsaDibeli != 100000 || hp == null && hp.Length <= 9 && hp.Length >= 13 && hp == null)
            {
                Console.Write("");
            }
            else
            {

                Console.WriteLine("{0} {1} [{2}]", jenispulsa, pulsaDibeli, hp);
            }
        }
    }
}
