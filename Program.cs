using System;

namespace ResponsiPemrograman4345
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nama     : Ega Saputra Hutagalung");
            Console.WriteLine("NIM      : 21.11.4345");

            Console.WriteLine("\n");


            Karyawan karyawan1 = new Karyawan(4345, "Ega ", 4200000);
            Karyawan karyawan2 = new Karyawan(1928, "Zino", 23200000);
            Karyawan karyawan3 = new Karyawan(2065, "Mazino", -1000000);


            Console.WriteLine(" NO | NIK / NAMA\t\t | Gaji Bulanan\t |");
            Console.WriteLine("==================================================");
            Console.WriteLine(" 1. | {0} {1} \t\t | {2}\t |", karyawan1.NIK, karyawan1.Nama, karyawan1.GajiBulanan);
            Console.WriteLine(" 2. | {0} {1} \t\t | {2}\t |", karyawan2.NIK, karyawan2.Nama, karyawan2.GajiBulanan);
            Console.WriteLine(" 3. | {0} {1} \t\t | {2}\t\t |", karyawan3.NIK, karyawan3.Nama, karyawan3.GajiBulanan);

            Console.WriteLine("\n\nAsyikkkk naik gaji 10%\n");

            Console.WriteLine(" NO | NIK / NAMA\t\t | Gaji Bulanan\t |");
            Console.WriteLine("==================================================");
            Console.WriteLine(" 1. | {0} {1} \t\t | {2}\t |", karyawan1.NIK, karyawan1.Nama, karyawan1.NaikGaji);
            Console.WriteLine(" 2. | {0} {1} \t\t | {2}\t |", karyawan2.NIK, karyawan2.Nama, karyawan2.NaikGaji);
            Console.WriteLine(" 3. | {0} {1} \t\t | {2}\t\t |", karyawan3.NIK, karyawan3.Nama, karyawan3.GajiBulanan);


            Console.ReadKey();
        }
    }

}