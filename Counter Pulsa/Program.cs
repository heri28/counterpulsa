using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Counter_Pulsa
{
    class Program
    {
        static void utama()
        {
            Stock stock = new Stock();
            Console.Clear();
            bool cek = true;
            do
            {
                cek = true;
                Console.Clear();
                Console.Title = "Counter_Pulsa";
                stock.utama();
                Console.SetCursorPosition(5, 8); Console.WriteLine("1. Isi Pulsa Elektrik"); Console.SetCursorPosition(50, 8); Console.Write("Isi Pulsa Listrik .3");
                Console.SetCursorPosition(5, 10); Console.Write("2. Pulsa Voucher"); Console.SetCursorPosition(50, 10); Console.Write("Pembayaran PDAM   .4");
                Console.SetCursorPosition(50, 12); Console.Write("Lihat Laporan     .5");
                Console.Write("\nPilihan: ");
                switch (Console.ReadLine())
                {
                    case "1":
                            Console.Clear();
                            stock.utama();
                            Console.SetCursorPosition(5, 9); Console.WriteLine("1.AS");
                            Console.SetCursorPosition(5, 11); Console.WriteLine("2.SIMPATI");
                            Console.SetCursorPosition(5, 13); Console.WriteLine("3.XL");
                            Console.SetCursorPosition(50, 9); Console.WriteLine("4.IM3");
                            Console.SetCursorPosition(50, 11); Console.WriteLine("5.MENTARI");
                            Console.SetCursorPosition(50, 13); Console.WriteLine("6.AXIS");
                            
                            stock.jualPulsa();
                            Console.ReadKey();
                            
                        break;

                    case "2":
                        Console.Clear();
                        stock.utama();
                            Console.SetCursorPosition(5, 9); Console.WriteLine("1.AS");
                            Console.SetCursorPosition(5, 11); Console.WriteLine("2.SIMPATI");
                            Console.SetCursorPosition(5, 13); Console.WriteLine("3.XL");
                            Console.SetCursorPosition(50, 9); Console.WriteLine("4.IM3");
                            Console.SetCursorPosition(50, 11); Console.WriteLine("5.MENTARI");
                            Console.SetCursorPosition(50, 13); Console.WriteLine("6.AXIS");
                        stock.jualVoucher();
                        Console.ReadKey();
                        break;

                    case "3":
                        Console.Clear();
                        stock.utama();
                            Console.SetCursorPosition(5, 9); Console.WriteLine("1.20000");
                            Console.SetCursorPosition(5, 11); Console.WriteLine("2.50000");
                            Console.SetCursorPosition(5, 13); Console.WriteLine("3.100000");
                            Console.SetCursorPosition(50, 9); Console.WriteLine("4.200000");
                            Console.SetCursorPosition(50, 11); Console.WriteLine("5.500000");
                            Console.SetCursorPosition(50, 13); Console.WriteLine("6.1000000");
                            stock.jualToken();
                        Console.ReadKey();
                        break;

                    case "4":
                        Console.Clear();
                        stock.utama();
                        stock.TampilTransaksi();
                        Console.ReadKey();
                        break;

                    case "5":
                        Console.Clear();
                        stock.utama();
                        stock.TampilTransaksi();
                        Console.ReadKey();
                        break;
                }
            } while (cek);
            
        }
        
        static void Main(string[] args)
        {
            utama();
        }
    }
}
