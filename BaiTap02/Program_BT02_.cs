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
            sodu += soluong;
            Console.WriteLine("So tien da nap vao tai khoan là {0}",sodu);
            return sodu;
        }

    }
    class Program_BT02_
    {
        static void Main(string[] args)
        {
            TaiKhoa ThanhTu = new TaiKhoa("01234567","THANHTU",1000);
            Console.Write("Nhap so tien nap : ");
            int naptien = int.Parse(Console.ReadLine());
            Console.WriteLine("So du hien tai la : {0}",ThanhTu.getsodu()+naptien);
            Console.Write("Nhap so tien thanh toan : ");
            int thanhtoan = int.Parse(Console.ReadLine());
            Console.WriteLine("So tien hien tai la : {0}", ThanhTu.getsodu() + naptien - thanhtoan);
            Console.Write("Nhap so tien chuyen khoan : ");
            int chuyenkhoan = int.Parse(Console.ReadLine());
            if (chuyenkhoan >= ThanhTu.getsodu() + naptien - thanhtoan)
            {
                Console.WriteLine("So tien khong hop le");
            }
            else
            {
                Console.Write("So tien hien tai la : {0}", ThanhTu.getsodu() + naptien - thanhtoan - chuyenkhoan);
            }
            Console.ReadLine();
        }
    }
}

