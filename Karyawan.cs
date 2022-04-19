using System;
using System.Collections.Generic;
using System.Text;

namespace ResponsiPemrograman4345
{
    class Karyawan
    {
        public int NIK { get; set; }
        public string Nama { get; set; }
        public int GajiBulanan { get; set; }
        public int NaikGaji { get; set; }

        public Karyawan(int nik, string nama, int gajiBulanan)
        {
            this.NIK = nik;
            this.Nama = nama;

            if (gajiBulanan < 0)
            {
                this.GajiBulanan = 0;
                NaikGaji = Convert.ToInt32((GajiBulanan * 1.1));
            }
            else
            {
                this.GajiBulanan = gajiBulanan;
                NaikGaji = Convert.ToInt32((GajiBulanan * 1.1));
            }

        }

    }
}