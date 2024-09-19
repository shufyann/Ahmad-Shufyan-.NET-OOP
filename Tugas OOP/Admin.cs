using System;

namespace EMoneyApp
{
    // -----------------KELAS ADMIN (turunan dari User)-------------------------//
    public class Admin : User
    {
        // Konstruktor Admin
        public Admin(string nama, double emoney) : base(nama, "Admin", emoney)
        {
        }

        //----------(METHOD) ADMIN bisa menambah saldo customer--------//
        public void TambahSaldo(Customer customer, double jumlah)
        {
            if (jumlah > 0)
            {
                customer.Emoney += jumlah;
                Console.WriteLine($"Berhasil menambahkan saldo Rp{jumlah}.");
            }
            else if (jumlah < 0)
            {
                customer.Emoney += jumlah;  // Mengurangi saldo jika jumlah negatif
                Console.WriteLine($"Berhasil mengurangi saldo Rp{-jumlah}.");
            }
            else
            {
                Console.WriteLine("Gagal mengupdate saldo. Masukkan angka selain 0.");
            }
        }
    }
}
