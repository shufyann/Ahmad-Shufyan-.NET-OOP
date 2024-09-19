using System;

namespace EMoneyApp
{
    // -----------------KELAS CUSTOMER (turunan dari User)-------------------------//
    public class Customer : User
    {
        // Konstruktor Customer
        public Customer(string nama, double emoney) : base(nama, "Customer", emoney)
        {
        }

        //--------------(METHOD) CUSTOMER melihat saldo------------------//
        public void LihatSaldo()
        {
            Console.WriteLine($"Saldo e-money Anda Rp{Emoney}.");
        }
    }
}
