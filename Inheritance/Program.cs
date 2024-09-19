using System;

namespace Inheritance
{
    //Parent class
    public class lingkaran
    {
        double luas;
        
        //method untuk menghitung luas lingkaran
        public int luasLingkaran(double r)
        {
            luas = 3.14*r*r;
            return (int)luas;
        }
    }
    
    //child class
    public class Tabung : lingkaran
    {
        double volume;

        public Tabung(int tinggi, double r)
        {
            //menggunakan metode luas lingkaran dari kelas lingkaran
            volume = tinggi*this.luasLingkaran(r);
        }

        public double getVolume()
        {
            return volume;
        }

        static void Main(string[] args)
        {
            //membuat objek
            Tabung tabung = new Tabung(5,5);

            //menampilkan volume tabung
            Console.WriteLine("Volume: "+ tabung.getVolume());
        }
    }
}