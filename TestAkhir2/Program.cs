using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAkhir2
{
    class Program
    {
        static void Main(string[] args)
        {
            int nilai;
            Console.Write("Masukan Nilai :");
            nilai = int.Parse(Console.ReadLine());

            if( nilai >= 80 )
            {
                Console.WriteLine("Nilai Anda : A");
            }
            else if( nilai >= 65 && nilai < 80)
            {
                Console.WriteLine("Nilai Anda : B");
            }
            else if( nilai >= 45 && nilai < 65)
            {
                Console.WriteLine("Nilai Anda : C");
            }
            else if( nilai >= 30 && nilai < 45)
            {
                Console.WriteLine("Nilai Anda : D");
            }
            else if( nilai < 30)
            {
                Console.WriteLine("Nilai Anda : E");
            }
            else
            {
                Console.WriteLine("beng beng beng");
            }
            Console.ReadKey();
        }
    }
}
