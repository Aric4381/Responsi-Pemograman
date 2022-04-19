using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemograman4381
{
    class Karyawan
    {
        public Karyawan()
        {

        } 
        public Karyawan(string nama, string nik, int gajibulanan)
        {
            Nama = nama;
            Nik = nik;
            GajiBulanan = gajibulanan;
        }
        public string Nama { get; set; }
        public string Nik { get; set; }
        public int GajiBulanan { get; set; }
    }
}
