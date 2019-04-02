using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Method";
            // deklarasi variabel
            int hasil;

            // membuat objek dari class calculator
            Calculator calculator = new Calculator();

            // panggil method Penjumlahan
            hasil = calculator.Penjumlahan(10, 2);
            CetakHasil("Hasil jumlah : " + hasil);

            // panggila method jumlah dengan 3 parameter (overload method)
            hasil = calculator.Penjumlahan(10, 2, 3);
            CetakHasil("Hasil penjumlah overload : " + hasil);

            // panggil method pengurangan
            hasil = calculator.Pengurangan(7, 2);
            CetakHasil("Hasil pengurangan : " + hasil);

            // panggil staticmethod, langung dari nama class nya
            hasil = Calculator.Perkalian(5, 2);
            CetakHasil("Hasil perkalian : " + hasil);


            Console.ReadKey();
        }

        static void CetakHasil(string hasil) 
        {
            Console.WriteLine(hasil);    
        }
    }
}
