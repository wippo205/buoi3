using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi3
{
    class SinhVien
    {
        public int MaSinhVien { get; set; }
        public string HoTen { get; set; }
        public double DiemLT { get; set; }
        public double DiemTH { get; set; }

        public SinhVien(int maSinhVien, string hoTen, double diemLT, double diemTH)
        {
            MaSinhVien = maSinhVien;
            HoTen = hoTen;
            DiemLT = diemLT;
            DiemTH = diemTH;
        }

        public override string ToString()
        {
            return "Ma SV:" + MaSinhVien + "  " + "Ho ten:" + HoTen + "  " + "Điem LT:" + DiemLT + "  " + "Điem TH:" + DiemTH;

        }

        public bool KiemTraHopLe()
        {
            if (MaSinhVien <= 0)
                return false;
            if (string.IsNullOrEmpty(HoTen))
                return false;
            if (DiemLT < 0 || DiemLT > 10 || DiemTH < 0 || DiemTH > 10)
                return false;
            return true;
        }
    }
}


