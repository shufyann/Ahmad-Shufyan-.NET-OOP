using System;

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
}
