using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapTuLuyen03
{
    internal class Program_BTTL03_
    {
        static void Main(string[] args)
        {
            HangThucPham sp1 = new HangThucPham();
            sp1.maHang = "001";
            sp1.tenHang = "sua ong tho";
            sp1.donGia = 25000;
            sp1.ngaySanXuat = DateTime.Parse("01/01/2024");
            sp1.ngayHetHan = DateTime.Parse("01/05/2024");
            Console.WriteLine("{0} {1} {2} {3:dd/MM/yyyy} {4:dd/MM/yyyy}",sp1.maHang,sp1.tenHang,sp1.donGia,sp1.ngaySanXuat,sp1.ngayHetHan);
            if(sp1.KiemTraHetHan())
            {
                Console.WriteLine("San pham con han su dung");
            }
            else
            {
                Console.WriteLine("San pham da het han");
            }
            Console.ReadLine();
        }
    }
}
