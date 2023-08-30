using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            SinhVien sv1 = new SinhVien(2001207444, "Nguyen Huu Dai", -1, -2);
            Console.WriteLine(sv1);

            if (sv1.KiemTraHopLe())
                Console.WriteLine("Sinh viên hop ke");
            else
                Console.WriteLine("Sinh vien khong hop le");

            Console.Write("\n \n \n \n");

            SinhVien sv2 = new SinhVien(2001207445, "Nguyen Huu Dat", 1, 2);
            Console.WriteLine(sv2);

            if (sv2.KiemTraHopLe())
                Console.WriteLine("Sinh viên hop ke");
            else
                Console.WriteLine("Sinh vien khong hop le");
            Console.ReadLine();

            Console.Write("\n \n \n \n");

          
        }
    }
}
