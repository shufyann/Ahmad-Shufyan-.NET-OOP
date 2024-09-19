using System;
using System.Collections.Generic;

namespace EMoneyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //-------MEMBUAT DAFTAR CUSTOMER DAN ADMIN--------//
            List<Customer> customers = new List<Customer>()
            {
                new Customer("Joko", 50000),
                new Customer("Widodo", 75000),
            };

            Admin admin = new Admin("Admin", 0);

            //-------INPUT UNTUK MENENTUKAN ADMIN ATAU CUSTOMER-----------//
            Console.Write("Masukkan role (admin/customer): ");
            string role = Console.ReadLine().ToLower();

            //----------ADMIN----------//
            if (role == "admin")
            {
                Console.WriteLine("\nDaftar Customer:");
                for (int i = 0; i < customers.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {customers[i].Nama} - Saldo: Rp{customers[i].Emoney}");
                }

                Console.Write("\nPilih nomor customer: ");
                int pilihan = Convert.ToInt32(Console.ReadLine());

                if (pilihan > 0 && pilihan <= customers.Count)
                {
                    Console.Write($"Masukkan jumlah saldo: ");
                    double jumlahSaldo = Convert.ToDouble(Console.ReadLine());

                    admin.TambahSaldo(customers[pilihan - 1], jumlahSaldo);

                    // Menampilkan saldo terbaru
                    Console.WriteLine($"\nSaldo terbaru {customers[pilihan - 1].Nama} adalah Rp{customers[pilihan - 1].Emoney}.");
                }
                else
                {
                    Console.WriteLine("Customer tidak ditemukan.");
                }
            }
            //----------CUSTOMER----------//
            else if (role == "customer")
            {
                Console.Write("Masukkan nama Anda: ");
                string namaCustomer = Console.ReadLine();

                // Cari customer berdasarkan nama
                Customer customer = customers.Find(c => c.Nama.ToLower() == namaCustomer.ToLower());

                if (customer != null)
                {
                    customer.LihatSaldo();
                }
                else
                {
                    Console.WriteLine("Customer tidak ditemukan.");
                }
            }
            else
            {
                Console.WriteLine("Role tidak valid.");
            }
        }
    }
}
