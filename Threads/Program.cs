using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threads
{
    class Program
    {
        public static void Mesero1Atiende()
        {
            for (int i=0; i<100;i++) {
                Console.WriteLine("Mesero 1 Sirve Patillo No: "+i);
            }
        }
        public static void Mesero2Atiende()
        {
            Console.WriteLine("Mesero 2 Sirve Patillo ");
        }
        public static void Mesero3Atiende()
        {
            Console.WriteLine("Mesero 3 Sirve Patillo ");
        }
        public static void Mesero4Atiende()
        {
            Console.WriteLine("Mesero 4 Sirve Patillo ");
        }
        public static void Mesero5Atiende()
        {
            Console.WriteLine("Mesero 5 Sirve Patillo ");
        }
        public static void Mesero6Atiende()
        {
            Console.WriteLine("Mesero 6 Sirve Patillo ");
        }
        static void Main(string[] args)
        {
            Mesero1Atiende();
            Mesero2Atiende();
            Mesero3Atiende();
            Mesero4Atiende();
            Mesero5Atiende();
            Mesero6Atiende();
        }
        
    }
 
}

