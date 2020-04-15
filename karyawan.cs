using System;
using System.Collections.Generic;
using System.Text;

namespace ResponsiPemrograman2917
{
    class Karyawan
    {

        public string NIK;
        public string NAMA;
        public int gajibulanan;
        public Karyawan(string nik, string nama, int gajibulanan)
        {
            this.NIK = NIK;
            this.NAMA = NAMA;
            if (gajibulanan < 0)
            {
                this.NIK = "0";
                Console.WriteLine("Maaf Gaji Yang Anda Masukkan Tidak boleh Kurang Dari 0");
            }
            else
            {
                this.gajibulanan = gajibulanan;
            }
        }
    }
}
