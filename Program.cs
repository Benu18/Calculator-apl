using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Calculator
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Title = "Aplikasi Calculator";

            Console.Write("Pilih Menu Calculator : \n");
            Console.Write("1. Penjumlahan \n");
            Console.Write("2. Pembagian \n");
            Console.Write("3. Perkalian \n");
            Console.Write("4. Pengurangan \n");
            Console.WriteLine();

            Console.WriteLine("Input Pilihan Menu : ");

            int menu = Convert.ToInt32(Console.ReadLine());
            Console.Write("Inputkan Nilai A = ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Inputkan Nilai B = ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            switch (menu)
            {
                case 1:
                    Console.WriteLine("Hasil Penjumlahan " + a + " + " + b + " = " + penambahan(a, b));
                    break;
                case 2:
                    Console.WriteLine("Hasil Pembagian {0} / {1} = {2} ", a, b, pembagian(a, b));
                    break;
                case 3:
                    Console.WriteLine("Hasil Perkalian {0} * {1} = {2} ", a, b, perkalian(a, b));
                    break;
                case 4:
                    Console.WriteLine("Hasil Pengurangan {0} - {1} = {2} ", a, b, pengurangan(a, b));
                    break;
                default:
                    Console.WriteLine("Maaf, Menu Yang Anda Pilih Tidak Tersedia ");
                    break;

            }

            Console.WriteLine("Tekan Sebarang Key Untuk Keluar......\n");
            Console.ReadKey();


        }

        static int penambahan(int a, int b)
        {
            return a + b;
        }

        static int pembagian(int a, int b)
        {
            return a / b;
        }

        static int perkalian(int a, int b)
        {
            return a * b;
        }

        static int pengurangan(int a, int b)
        {
            return a - b;
        }
    }
}

