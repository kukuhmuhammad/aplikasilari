using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness
{
    class Program
    {
        static void Main(string[] args)
        {
            //variabel
            string input;
            int total=0;

            //looping
            while (true)
            {
                //keluarkan pertanyaan
                Console.WriteLine("berapa lama berolahraga ?");

                //minta input dari user
                input = Console.ReadLine();

                //menambahkan inputnya
                total = total + Int32.Parse(input);

                //keluar bila user masukin "quit"
                if (input == "quit")
                {
                    break;
                }

                //ngeluarin inputnya
                Console.WriteLine("Selamat anda sudah berlari melawan kenyataan sejauh " + input + " menit");




        }   }
    }
}
