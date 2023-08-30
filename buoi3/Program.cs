using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi3
{
    class Program
    {
        //static void Main(string[] args)
        //{
            
        //    SinhVien sv1 = new SinhVien(2001207444, "Nguyen Huu Dai", -1, -2);
        //    Console.WriteLine(sv1);

        //    if (sv1.KiemTraHopLe())
        //        Console.WriteLine("Sinh viên hop ke");
        //    else
        //        Console.WriteLine("Sinh vien khong hop le");

        //    Console.Write("\n \n \n \n");

        //    SinhVien sv2 = new SinhVien(2001207445, "Nguyen Huu Dat", 1, 2);
        //    Console.WriteLine(sv2);

        //    if (sv2.KiemTraHopLe())
        //        Console.WriteLine("Sinh viên hop ke");
        //    else
        //        Console.WriteLine("Sinh vien khong hop le");
        //    Console.ReadLine();

        //    Console.Write("\n \n \n \n"); 
        //}

        static void Main(string[] args)
        {
            HinhTamGiac tg1 = new HinhTamGiac(4, 5, 6);
            HinhTamGiac tg2 = new HinhTamGiac(3, 8, 10);
            HinhTamGiac tg3 = new HinhTamGiac(5, 5, 5);
            HinhTamGiac tg4 = new HinhTamGiac(6, 6, 8);
            HinhTamGiac tg5 = new HinhTamGiac(3, 4, 5);

            Console.WriteLine("Canh A    Canh B    Canh C         Kieu            Chu Vi             Dien Tich \n");
            Console.WriteLine(tg1.ToString());
            Console.WriteLine(tg2.ToString());
            Console.WriteLine(tg3.ToString());
            Console.WriteLine(tg4.ToString());
            Console.WriteLine(tg5.ToString());
            Console.ReadLine();
        }
    }
}
