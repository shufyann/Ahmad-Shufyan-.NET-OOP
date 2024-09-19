using System;

namespace UserManagement
{
    class user
    {
        //Atribut
        string nama = "Fian";
        string role = "SA";
        int emoney = 1000000000;

        //method
        public void UserDetail()
        {
            Console.WriteLine("Ini detail usernya");
        }

        //Object
        static void Main(string[] args)
        {
            //kelas itu merupakan blueprint dari sebuah object
            user userBootcamp = new user();
            userBootcamp.UserDetail();
            Console.WriteLine("Nama:  "+userBootcamp.nama);
            Console.WriteLine("Role:  " + userBootcamp.role);
            Console.WriteLine("emoney:  " + userBootcamp.emoney);
        }
    }
}

