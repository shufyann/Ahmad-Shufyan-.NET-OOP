using System;
using System.Collections.Generic;

namespace EMoneyApp
{
    // Kelas User (parent class)
    public class User
    {
        public string Nama { get; set; }
        public string Role { get; set; }
        public double Emoney { get; set; }

        // Konstruktor untuk inisialisasi User
        public User(string nama, string role, double emoney)
        {
            Nama = nama;
            Role = role;
            Emoney = emoney;
        }
    }

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
            else if (jumlah<0)
            {
                customer.Emoney -= jumlah;
                Console.WriteLine($"Berhasil mengurangi saldo Rp{jumlah}.");
            }
            else
            {
                Console.WriteLine("Gagal mengupdate saldo. Masukkan angka selain 0.");
            }
        }
    }

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
