using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap02
{
    class TaiKhoa
    {
        private string id, name;
        private int sodu;
        public TaiKhoa(string id, string name, int sodu)
        {
            this.id = id;
            this.name = name;
            this.sodu = sodu;
        }
        public string getid()
        {
            return id;
        }
        public string getname()
        {
            return name;
        }
        public int getsodu()
        {
            return sodu;
        }
        public int NapTien(int soluong)
        {
            if (soluong > 0)
            {
                sodu += soluong;
            }
            else
            {
                Console.WriteLine("So tien nap phai lon hon 0");
            }
            return sodu;
        }
        public int ThanhToan(int soluong)
        {
            if(soluong > 0 || soluong <= sodu)
            {
                sodu -= soluong;
            }
            return sodu;
        }
        public int ChuyenKhoan(TaiKhoa acc ,int soluong)
        {
            if(soluong <= sodu)
            {
                sodu-=soluong;
                acc.sodu+= soluong;
            }
            return sodu;
        }

    }
    class Program_BT02_
    {
        static void Main(string[] args)
        {
            TaiKhoa NguyenTu = new TaiKhoa("01234567", "NGUYENTU", 1000);
            Console.Write("Nhap so tien nap : ");
            int naptien = int.Parse(Console.ReadLine());
            NguyenTu.NapTien(naptien);
            Console.Write("Nhap so tien thanh toan : ");
            int thanhtoan = int.Parse(Console.ReadLine());
            NguyenTu.ThanhToan(thanhtoan);
            Console.Write("Nhap so tien chuyen khoan : ");
            int chuyenkhoan = int.Parse(Console.ReadLine());

            TaiKhoa ThanhTu = new TaiKhoa("01234567","THANHTU",1000);
            ThanhTu.NapTien(200);
            ThanhTu.ThanhToan(50);
            ThanhTu.ChuyenKhoan(NguyenTu, 100);

            NguyenTu.ChuyenKhoan(ThanhTu, chuyenkhoan);

            Console.WriteLine("id : {0}  name : {1} sodu : {2}", NguyenTu.getid(), NguyenTu.getname(), NguyenTu.getsodu());
            Console.WriteLine("id : {0}  name : {1} sodu : {2}", ThanhTu.getid(), ThanhTu.getname(), ThanhTu.getsodu());

            Console.ReadLine();
        }
    }
}

