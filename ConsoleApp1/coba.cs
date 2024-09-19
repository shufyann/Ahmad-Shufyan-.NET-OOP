using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp2;

namespace ConsoleApp1
{
    internal class coba
    {
        static void Main(string[] args)
        {
            // Membuat instance mobil menggunakan class MstProduct
            MstProduct mobil1 = new MstProduct("Civic", "Honda", 500000000, 2023);

            // Menampilkan informasi produk mobil
            Console.WriteLine("Informasi Produk Mobil:");
            mobil1.TampilkanInfo();

            // Membuat instance mobil lain
            MstProduct mobil2 = new MstProduct("Fortuner", "Toyota", 700000000, 2022);
            Console.WriteLine("\nInformasi Produk Mobil Kedua:");
            mobil2.TampilkanInfo();

            MstProduct mobil3 = new MstProduct("F50", "Ferrari", 1000000000, 1950);
            Console.WriteLine("\nIni mobil ke-3:");
            mobil3.TampilkanInfo();
        }
    }
}
