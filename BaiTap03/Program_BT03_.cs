using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap03
{
    class Program_BT03_
    {
        static void Main(string[] args)
        {
            CauA();
            CauB();
            Console.ReadLine();
        }
        static void CauA()
        {
            Console.WriteLine("--Nhap phan so thu nhat : ");
            Console.Write("Nhap tu so : ");
            int tuso = int.Parse(Console.ReadLine());
            Console.Write("Nhap mau so : ");
            int mauso = int.Parse(Console.ReadLine());
            PhanSo ps1 = new PhanSo(tuso, mauso);
            ps1.getTuso();
            ps1.getMauso();

            Console.WriteLine("--Nhap phan so thu hai : ");
            Console.Write("Nhap tu so : ");
            tuso = int.Parse(Console.ReadLine());
            Console.Write("Nhap mau so : ");
            mauso = int.Parse(Console.ReadLine());
            PhanSo ps2 = new PhanSo(tuso, mauso);
            ps2.getTuso();
            ps2.getMauso();

            PhanSo Tong = ps1.Cong(ps2);
            Tong.ToiGian();
            PhanSo Hieu = ps1.Tru(ps2);
            Hieu.ToiGian();
            PhanSo Tich = ps1.Nhan(ps2);
            Tich.ToiGian();
            PhanSo Thuong = ps1.Chia(ps2);
            Thuong.ToiGian();

            Console.WriteLine("Tong cua [{0}/{1}] + [{2}/{3}] = [{4}/{5}]",
                               ps1.getTuso(), ps1.getMauso(), ps2.getTuso(), ps2.getMauso(), Tong.getTuso(), Tong.getMauso());
            Console.WriteLine("Tong cua [{0}/{1}] - [{2}/{3}] = [{4}/{5}]",
                               ps1.getTuso(), ps1.getMauso(), ps2.getTuso(), ps2.getMauso(), Hieu.getTuso(), Hieu.getMauso());
            Console.WriteLine("Tong cua [{0}/{1}] * [{2}/{3}] = [{4}/{5}]",
                   ps1.getTuso(), ps1.getMauso(), ps2.getTuso(), ps2.getMauso(), Tich.getTuso(), Tich.getMauso());
            Console.WriteLine("Tong cua [{0}/{1}] / [{2}/{3}] = [{4}/{5}]",
                   ps1.getTuso(), ps1.getMauso(), ps2.getTuso(), ps2.getMauso(), Thuong.getTuso(), Thuong.getMauso());
        }
        static void CauB()
        {
            Console.Write("Nhap so n : ");
            int n = int.Parse(Console.ReadLine());

            PhanSo s =new PhanSo(0,1);
            for (int i = 1; i <= n; i++)
            {
                s = s.Cong(new PhanSo(1,i));
            }
            s.ToiGian();
            Console.WriteLine("Tong cua 1 + 1/2 + ... + 1/{0} = {1}/{2}",n,s.getTuso(),s.getMauso());
        }
    }
}
