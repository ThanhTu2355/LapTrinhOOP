using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapTuLuyen05
{
    class Program
    {
        static void Main(string[] args)
        {
            menu();
        }
        static void menu()
        {
            QuanLyCD quanlyCD = new QuanLyCD();

            int luaChon=0;
            do
            {
                Console.WriteLine("************CHUONG TRINH QUAN LY CD************");
                Console.WriteLine("0. Thoat");
                Console.WriteLine("1. Them CD");
                Console.WriteLine("2. Tinh gia trung binh");
                Console.WriteLine("3. Sap xep CD giam dan theo gia thanh");
                Console.WriteLine("4. Sap xep CD tang dan theo tua CD");
                Console.WriteLine("5. Xuat toan bo CD");
                Console.WriteLine("-----------------------------------------------");
                Console.Write("Bam chon : ");
                luaChon = int.Parse(Console.ReadLine());

                switch(luaChon)
                {
                    case 0:
                        break;
                    case 1:
                        CD cd = new CD();
                        Console.Write("Nhap ma cd: ");
                        cd.MaCD = int.Parse(Console.ReadLine());
                        Console.Write("Nhap tua cd: ");
                        cd.TuaCD = Console.ReadLine();
                        Console.Write("Nhap ca si: ");
                        cd.CaSi = Console.ReadLine();
                        Console.Write("Nhap so bai hat: ");
                        cd.SoBaiHat = int.Parse(Console.ReadLine());
                        Console.Write("Nhap gia tien: ");
                        cd.GiaTien = int.Parse(Console.ReadLine());
                        quanlyCD.ThemCD(cd);
                        break;
                    case 2:
                        double kq = quanlyCD.TinhGiaTrungBinh();
                        Console.WriteLine("Gia thanh trung binh : {0:#,##0.00}", kq);
                        break;
                    case 3:
                        quanlyCD.SapXepGiamGiaThanh();
                        Console.WriteLine("Sap xep giam theo gia thanh: ");
                        break;
                    case 4:
                        quanlyCD.SapXepTangDanTheoTuaCD();
                        Console.WriteLine("Sap xep tang theo tua CD: ");
                        break;
                    case 5:
                        quanlyCD.XuatketQua();
                        break;
                }
            } while (luaChon != 0);
        }
    }
}
