using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapTuLuyen02
{
    class Vehicles
    {
        private string TenChuXe;
        private string LoaiXe;
        private int DungTichXe;
        private int GiaXe;

        public Vehicles(string TenChuXe, string LoaiXe, int DungTichXe, int GiaXe)
        {
            this.TenChuXe = TenChuXe;
            this.LoaiXe = LoaiXe;
            this.DungTichXe = DungTichXe;
            this.GiaXe = GiaXe;
        }

        public string TenChu
        {
            set { TenChuXe = value; }
            get { return TenChuXe; }
        }
        public string Loai
        {
            set { LoaiXe = value; }
            get { return LoaiXe; }
        }
        public int DungTich
        {
            set { DungTichXe = value; }
            get { return DungTichXe; }
        }
        public int Gia
        {
            set { GiaXe = value; }
            get { return GiaXe; }
        }
        public double Thue()
        {
            if(DungTich<100)
            {
                return GiaXe * 0.01;
            }
            else if(DungTich>=100&&DungTich<=200)
            {
                return GiaXe * 0.03;
            }
            return GiaXe * 0.05;
        }
    }
    internal class Program_BTTL02_
    {
        static void Main(string[] args)
        {
            Console.WriteLine("- Nhap thong tin xe thu 1 : ");
            Console.Write(" Nhap ten chu xe : ");
            string tenChuXe = Console.ReadLine();
            Console.Write(" Nhap loai xe : ");
            string loaiXe = Console.ReadLine();
            Console.Write(" Nhap dung tich cua xe : ");
            int dungTich = int.Parse(Console.ReadLine());
            Console.Write(" Nhap gia xe : ");
            int giaXe = int.Parse(Console.ReadLine());
            Vehicles Xe1 = new Vehicles(tenChuXe, loaiXe, dungTich, giaXe);

            Console.WriteLine("- Nhap thong tin xe thu 2 : ");
            Console.Write(" Nhap ten chu xe : ");
            tenChuXe = Console.ReadLine();
            Console.Write(" Nhap loai xe : ");
            loaiXe = Console.ReadLine();
            Console.Write(" Nhap dung tich cua xe : ");
            dungTich = int.Parse(Console.ReadLine());
            Console.Write(" Nhap gia xe : ");
            giaXe = int.Parse(Console.ReadLine());
            Vehicles Xe2 = new Vehicles(tenChuXe, loaiXe, dungTich, giaXe);

            Console.WriteLine("- Nhap thong tin xe thu 3 : ");
            Console.Write(" Nhap ten chu xe : ");
            tenChuXe = Console.ReadLine();
            Console.Write(" Nhap loai xe : ");
            loaiXe = Console.ReadLine();
            Console.Write(" Nhap dung tich cua xe : ");
            dungTich = int.Parse(Console.ReadLine());
            Console.Write(" Nhap gia xe : ");
            giaXe = int.Parse(Console.ReadLine());
            Vehicles Xe3 = new Vehicles(tenChuXe, loaiXe, dungTich, giaXe);

            Console.WriteLine("|{0,-20}|{1,-15}|{2,10}|{3,25}|{4,20}|","Ten chu xe","Loai xe","Dung tich","Tri gia","Thue");
            Console.WriteLine("------------------------------------------------------------------------------------------------");
            Console.WriteLine("|{0,-20}|{1,-15}|{2,10}|{3,25}|{4,20}|", Xe1.TenChu, Xe1.Loai, Xe1.DungTich, Xe1.Gia, Xe1.Thue());
            Console.WriteLine("|{0,-20}|{1,-15}|{2,10}|{3,25}|{4,20}|", Xe2.TenChu, Xe2.Loai, Xe2.DungTich, Xe2.Gia, Xe2.Thue());
            Console.WriteLine("|{0,-20}|{1,-15}|{2,10}|{3,25}|{4,20}|", Xe3.TenChu, Xe3.Loai, Xe3.DungTich, Xe3.Gia, Xe3.Thue());
            Console.ReadLine();
        }
    }
}
