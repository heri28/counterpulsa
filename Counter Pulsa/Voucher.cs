using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Counter_Pulsa
{
    class Voucher
    {
        public enum jenisVoucher
        {
            nol, AS, SIMPATI, XL, IM3, MENTARI, AXIS
        }

        public jenisVoucher jenisvoucher { get; set; }
        public int voucherdibeli {get; set;}
        public string novoucher;
        bool cek,cek1= true;

        public Voucher()
        {
            Random rnd = new Random();
            int angka = rnd.Next(100000000, 999999999);
            int angka1 = rnd.Next(888888888, 999999999);
            novoucher = Convert.ToString(angka + angka1 + 9999999);
            do
            {
                Console.WriteLine();
                Console.Write("Jenis voucher yang dibeli : ");
                jenisvoucher = (jenisVoucher)int.Parse(Console.ReadLine());
            } while ((int)jenisvoucher != 1 && (int)jenisvoucher != 2 && (int)jenisvoucher != 3 && (int)jenisvoucher != 4
                && (int)jenisvoucher != 5 && (int)jenisvoucher != 6);

            if ((int)jenisvoucher != 1 && (int)jenisvoucher != 2 && (int)jenisvoucher != 3 && (int)jenisvoucher != 4
                && (int)jenisvoucher != 5 && (int)jenisvoucher != 6)
            {
                cek1 = false;
            }
            else
            {
                Console.WriteLine("\n");
                do
                {
                    cek = true;
                    Console.SetCursorPosition(5, 19); Console.Write("Nominal Voucher : ");
                    voucherdibeli = Convert.ToInt32(Console.ReadLine());
                } while (cek == false);
                if (voucherdibeli != 500000 && voucherdibeli != 10000 && voucherdibeli != 20000
                    && voucherdibeli != 50000 && voucherdibeli != 100000)
                {
                    Console.WriteLine("Voucher tidak tersedia !");
                    Console.WriteLine("Hanya tersedia voucher 10000, 20000, 50000, 100000, 500000");
                    cek = false;
                }
                else
                {
                    Console.WriteLine("Kode voucer {0} {1} Ribu adalah {2}", jenisvoucher, voucherdibeli, novoucher);
                }
            }
        }

        public void detailvoucher()
        {
            if ((int)jenisvoucher != 1 && (int)jenisvoucher != 2 && (int)jenisvoucher != 3 && (int)jenisvoucher != 4
                && (int)jenisvoucher != 5 && (int)jenisvoucher != 6 || voucherdibeli != 500000 && voucherdibeli != 10000
                && voucherdibeli != 20000 && voucherdibeli != 50000 && voucherdibeli != 100000)
            {
                Console.Write("");
            }
            else
            {
                Console.WriteLine("[{0}] {1} {2}", jenisvoucher, voucherdibeli, novoucher);
            }
        }

    }
}
