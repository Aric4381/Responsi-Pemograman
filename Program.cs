using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemograman4381
{
    class Program
    {
        static void Main(string[] args)
        {
            Karyawan karyawan1 = new Karyawan();

            karyawan1.Nik = "21.11.4381";
            karyawan1.Nama = "Aric";
            karyawan1.GajiBulanan = 50000000;

            Karyawan karyawan2 = new Karyawan();

            karyawan2.Nik = "21.11.777";
            karyawan2.Nama = "Berry";
            karyawan2.GajiBulanan = -10000000;

            if(karyawan1.GajiBulanan < 0)
            {
                karyawan1.GajiBulanan = 0;
            }

            if (karyawan2.GajiBulanan < 0)
            {
                karyawan2.GajiBulanan = 0;
            }

            Console.WriteLine("No.\tNik\t\tNama\t\tGaji Bulanan");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("1.\t{0}\t{1}\t\t{2}", karyawan1.Nik, karyawan1.Nama, karyawan1.GajiBulanan);
            Console.WriteLine("2.\t{0}\t{1}\t\t{2}", karyawan2.Nik, karyawan2.Nama, karyawan2.GajiBulanan);
            Console.WriteLine("\n");
            Console.WriteLine("\t\t==GAJIMU NAIK 10%==");
            Console.WriteLine("\n");
            Console.WriteLine("No.\tNik\t\tNama\t\tGaji Bulanan");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("1.\t{0}\t{1}\t\t{2}", karyawan1.Nik, karyawan1.Nama, karyawan1.GajiBulanan + (karyawan1.GajiBulanan * 0.1));
            Console.WriteLine("2.\t{0}\t{1}\t\t{2}", karyawan2.Nik, karyawan2.Nama, karyawan2.GajiBulanan + (karyawan2.GajiBulanan * 0.1));
            Console.ReadKey();
        }
    }
}
