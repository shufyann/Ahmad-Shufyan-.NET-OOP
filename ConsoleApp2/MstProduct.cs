using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class MstProduct
    {
        public string Nama { get; set; }
        public string Merek { get; set; }
        public decimal Harga { get; set; }
        public int TahunProduksi {  get; set; }

        public MstProduct(string nama, string merek, decimal harga, int tahunProduksi)
        {
            Nama = nama;
            Merek = merek;
            Harga = harga;
            TahunProduksi = tahunProduksi;
        }
        public void TampilkanInfo()
        {
            Console.WriteLine($"Nama Mobil: {Nama}");
            Console.WriteLine($"Merek: {Merek}");
            Console.WriteLine($"Harga: Rp {Harga:N0}");
            Console.WriteLine($"Tahun Produksi: {TahunProduksi}");
        }
    }
}
