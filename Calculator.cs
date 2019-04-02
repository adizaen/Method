using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanMethod
{
    class Calculator
    {
        public int Penjumlahan(int a, int b)
        {
            return a + b;
        }

        // overload method : menggunakan nama method sama.
        // tetapi diberi pembeda seperti tipe data/jumlah parameter formal.

        public int Penjumlahan(int a, int b, int c)     
        {
            return a + b + c;
        }
        public int Pengurangan(int a, int b)
        {
            return a - b;
        }

        // static : hanya bisa diakses oleh class yang mengandung method static itu
        // dalam hal ini class Calculator
        public static int Perkalian(int a, int b)   
        {
            return a * b;
        }
    }
}
