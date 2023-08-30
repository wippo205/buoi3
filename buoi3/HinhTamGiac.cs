using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi3
{


class HinhTamGiac
{
    private double canhA;
    private double canhB;
    private double canhC;

    public HinhTamGiac()
    {
        canhA = 0;
        canhB = 0;
        canhC = 0;
    }

    public HinhTamGiac(double a, double b, double c)
    {
        if (a <= 0 || b <= 0 || c <= 0 || !LaTamGiac(a, b, c))
        {
            canhA = 0;
            canhB = 0;
            canhC = 0;
        }
        else
        {
            canhA = a;
            canhB = b;
            canhC = c;
        }
    }

    public double CanhA
    {
        get { return canhA; }
        set { if (value > 0 && LaTamGiac(value, canhB, canhC)) canhA = value; }
    }

    public double CanhB
    {
        get { return canhB; }
        set { if (value > 0 && LaTamGiac(canhA, value, canhC)) canhB = value; }
    }

    public double CanhC
    {
        get { return canhC; }
        set { if (value > 0 && LaTamGiac(canhA, canhB, value)) canhC = value; }
    }

    public double TinhChuVi()
    {
        return CanhA + CanhB + CanhC;
    }

    public double TinhDienTich()
    {
        double p = TinhChuVi() / 2;
        return Math.Sqrt(p * (p - CanhA) * (p - CanhB) * (p - CanhC));
    }

    public string KieuTamGiac()
    {
        if (CanhA == CanhB && CanhB == CanhC)
            return "Đeu";
        if (CanhA == CanhB || CanhA == CanhC || CanhB == CanhC)
            return "Can";
        return "Thuong";
    }

    private bool LaTamGiac(double a, double b, double c)
    {
        return a + b > c && a + c > b && b + c > a;
    }

    public override string ToString()
    {
        string kieu = KieuTamGiac();
        return "  " + CanhA + "         " + CanhB + "         " + CanhC + "          " + kieu + "             " + TinhChuVi() + "             " + TinhDienTich();
    }
}


}