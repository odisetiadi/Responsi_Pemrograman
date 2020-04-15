using System;
using System.Collections.Generic;
using System.Text;

namespace ResponsiPemrograman2917
{
    class karyawan
    {
        public string nik;
        public string nama;
        public int gajibulanan;
        public Karyawan (string nik, string nama, int gajibulanan)
        {
            this.nik = nik;
            this.nama = nama;
            if (gajibulanan < 0)
            {
                this.nik = "0";
                Console.WriteLine("Maaf Gaji Yang Anda Masukkan Tidak boleh Kurang Dari 0");
            }
            else
            {
                this.gajibulanan = gajibulanan;
            }
        }
}
