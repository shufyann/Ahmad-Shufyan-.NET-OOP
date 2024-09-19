using System;

namespace Encapsulation
{
    // Class Lingkaran dengan enkapsulasi
    public class Lingkaran
    {
        // Private field untuk menyimpan nilai radius
        private double radius;

        // Public property untuk mengakses dan mengatur radius
        public double Radius
        {
            get { return radius; }
            set
            {
                if (value > 0)
                {
                    radius = value;
                }
                else
                {
                    throw new ArgumentException("Radius harus lebih besar dari 0");
                }
            }
        }

        // Method untuk menghitung luas lingkaran
        public double Luas()
        {
            return 3.14 * radius * radius; // πr^2
        }
    }

    // Class Tabung menggunakan Lingkaran sebagai komponen
    public class Tabung
    {
        private Lingkaran lingkaran; // Komponen lingkaran sebagai alas
        private double tinggi;

        // Konstruktor untuk inisiasi tabung
        public Tabung(double radius, double tinggi)
        {
            lingkaran = new Lingkaran();
            lingkaran.Radius = radius;
            this.tinggi = tinggi;
        }

        // Method untuk menghitung volume tabung
        public double Volume()
        {
            return lingkaran.Luas() * tinggi; // Volume = Luas alas * tinggi
        }

        // Method untuk menampilkan informasi luas dan volume tabung
        public void TampilkanInfo()
        {
            Console.WriteLine($"Luas Alas Lingkaran: {lingkaran.Luas()}");
            Console.WriteLine($"Volume Tabung: {this.Volume()}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Membuat objek Tabung dengan radius 7 dan tinggi 10
                Tabung tabung = new Tabung(-2, 10);

                // Menampilkan informasi luas alas dan volume tabung
                tabung.TampilkanInfo();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}


