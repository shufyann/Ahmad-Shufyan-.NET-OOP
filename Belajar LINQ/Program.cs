using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Belajar_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] bootcamp =
            //{
            //    "Andi","Bandi","Candi"
            //};

            //var query = from n in bootcamp select n;
            //foreach (var item in query)
            //{
            //    Console.WriteLine(item);
            //}

            //List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //var query = from n in numbers 
            //            where n>5 orderby n descending select n;
            //foreach (var item in query)
            //{
            //    Console.WriteLine(item);
            //}

            // Membuat objek Random untuk menghasilkan angka acak
            Random random = new Random();
            int angkaAcak = random.Next(1, 11); // Menghasilkan angka acak antara 1 dan 10
            int tebakan = 0;
            bool tebakanBenar = false;

            Console.WriteLine("Tebak angka dari 1 sampai 10:");

            
            while (!tebakanBenar)
            {
                Console.Write("Masukkan tebakan: ");
                string input = Console.ReadLine();

                
                if (int.TryParse(input, out tebakan) && tebakan >= 1 && tebakan <= 10)
                {
                    // Memeriksa apakah tebakan benar
                    if (tebakan == angkaAcak)
                    {
                        Console.WriteLine("Selamat! Tebakanmu benar.");
                        tebakanBenar = true; // Keluar dari loop
                    }
                    else
                    {
                        Console.WriteLine("Tebakan salah, coba lagi.");
                    }
                }
                else
                {
                    Console.WriteLine("Tolong masukkan angka yang valid antara 1 dan 10.");
                }
            }
        }
    }
}
//