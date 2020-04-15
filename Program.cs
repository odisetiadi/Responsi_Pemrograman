using System;

namespace ResponsiPemrograman2917
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;
            Karyawan karyawan1 = new Karyawan("190302123", "paijo", 3000000);
            Karyawan karyawan2 = new Karyawan("190302124", "jono", 2000000);
            Console.WriteLine("No Nik/nama   Gaji Bulanan");
            Console.WriteLine("1. " + karyawan1.NIK + " "    + karyawan1.NAMA + "\t" + karyawan1.gajibulanan);
            Console.WriteLine("1. " + karyawan2.NIK + " "  + karyawan2.NAMA + "\t\t" + karyawan2.gajibulanan);
            Console.WriteLine("\n\nAsyiiiiik Ada Kenaikan Gaji 10%!!\n");
            Console.WriteLine("No Nik/nama        Gaji Bulanan")
            n1 = (10 * karyawan1.gajibulanan) / 100;
            n2 = (10 * karyawan2.gajibulanan) / 100;
            Console.WriteLine("1. " + karyawan1.NIK + " " + karyawan1.NAMA + "\t" + (n1 + karyawan1.gajibulanan));
            Console.WriteLine("1. " + karyawan2.NIK + " " + karyawan2.NAMA+ "\t\t" + (n2 + karyawan2.gajibulanan));
            Console.ReadKey();
        }
    }
}
