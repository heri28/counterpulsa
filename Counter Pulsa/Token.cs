using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Counter_Pulsa
{
    class Token
    {
        public int pulsaDibeli =0;
        public int pulsaJual;
        public int hargaPulsa = 0;
        public int laba = 0;
        ConsoleKeyInfo nomPulsa;
        public string nometer { get; set; }
        public string notoken { get; set; }
        bool cek2= true;

        public Token()
        {
            Random rnd = new Random();
            int angka = rnd.Next(100000000, 999999999);
            int angka1 = rnd.Next(888888888, 999999999);
            notoken = Convert.ToString(angka + angka1 + 9999999);
                Console.SetCursorPosition(5, 21); Console.Write("Nominal Pulsa : ");
                nomPulsa = Console.ReadKey();
                do
                {
                    cek2 = true;
                    Console.SetCursorPosition(5, 19); Console.Write("Masukkan Nomor Meteran : ");
                    nometer = Console.ReadLine();
                } while (cek2 == false);
                if (nometer.Length <= 9 || nometer.Length >= 12 || nometer == null)
                {
                    Console.WriteLine("\tNomor Meteran Tidak Terdaftar, Periksa Nomor Meteran");
                }
                else
                {
                    pulsaJual = 1000; 
                }

                    switch (nomPulsa.KeyChar)
                    {
                        case '1':
                            hargaPulsa = pulsaJual;
                            break;
                        case '2':
                            hargaPulsa = pulsaJual;
                            break;
                        case '3':
                            hargaPulsa = pulsaJual;
                            break;
                        case '4':
                            hargaPulsa = pulsaJual;
                            break;
                        case '5':
                            hargaPulsa = pulsaJual;
                            break;
                        case '6':
                            hargaPulsa = pulsaJual;
                            break;
                        case '0':
                            cek2 = false;
                            break;
                        default:
                            break;
                    }


                    Console.SetCursorPosition(5, 22); Console.WriteLine("harga jual    : {0} IDR",
                                     hargaPulsa.ToString());
                    
                    Console.SetCursorPosition(5, 24); Console.WriteLine("-----------------------------");
                
                }

            public void detailToken()
            {
                Console.WriteLine("{0} {1} [{2}]", nometer, nomPulsa, notoken);
            }
    }
}

