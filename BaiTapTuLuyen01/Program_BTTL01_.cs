using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapTuLuyen01
{
    class SinhVien
    {
        private int MaSV;
        private string HoTenSV;
        private int DiemLT, DiemTH;

        public SinhVien()
        {
            MaSV = 0;
            HoTenSinhVien = null;
        }
        public SinhVien(int MaSV, string HoTenSV, int DiemLT, int DiemTH)
        {
            this.MaSV = MaSV;
            this.HoTenSV = HoTenSV;
            this.DiemLT = DiemLT;
            this.DiemTH = DiemTH;
        }
        public int MaSinhVien
        {
            set { MaSV = value; }
            get { return MaSV; }
        }
        public string HoTenSinhVien
        {
            set { HoTenSV = value; }
            get { return  HoTenSV; }
        }
        public int DiemLyThuyet
        {
            set { DiemLT = value; }
            get { return DiemLT; }
        }
        public int DiemThucHanh
        {
            set { DiemTH = value; }
            get { return DiemTH; }
        }
    }
    internal class Program_BTTL01_
    {
        static void Main(string[] args)
        {
            SinhVien SV1 = new SinhVien();
            SV1.MaSinhVien = 001;
            SV1.HoTenSinhVien = "Nguyen Thanh Tu";
            SV1.DiemLyThuyet = 7;
            SV1.DiemThucHanh = 8;

            SinhVien SV2 = new SinhVien();
            SV2.MaSinhVien = 002;
            SV2.HoTenSinhVien = "Nguyen Tan Phat";
            SV2.DiemLyThuyet = 8;
            SV2.DiemThucHanh = 9;

            Console.WriteLine(" Thong tin sinh vien thu 3 : ");
            Console.Write(" Nhap ma sinh vien : ");
            int maSV = int.Parse(Console.ReadLine());
            Console.Write(" Nhap ho ten sinh vien : ");
            string hoTenSV = (Console.ReadLine());
            Console.Write(" Nhap diem ly thuyet : ");
            int diemLT = int.Parse(Console.ReadLine());
            Console.Write(" Nhap diem thuc hanh : ");
            int diemTH = int.Parse(Console.ReadLine());
            SinhVien SV3 = new SinhVien(maSV, hoTenSV, diemLT, diemTH);

            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("|{0,7}|{1,-30}|{2,13}|{3,13}|", "MaSV", "Ho Ten SV", "DiemLyThuyet", "DiemThucHanh");
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("|{0,7}|{1,-30}|{2,13}|{3,13}|", SV1.MaSinhVien, SV1.HoTenSinhVien, SV1.DiemLyThuyet, SV1.DiemThucHanh);
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("|{0,7}|{1,-30}|{2,13}|{3,13}|", SV2.MaSinhVien, SV2.HoTenSinhVien, SV2.DiemLyThuyet, SV2.DiemThucHanh);
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("|{0,7}|{1,-30}|{2,13}|{3,13}|", SV3.MaSinhVien, SV3.HoTenSinhVien, SV3.DiemLyThuyet, SV3.DiemThucHanh);
            Console.WriteLine("--------------------------------------------------------------------");

            Console.ReadLine();
        }
    }
}
