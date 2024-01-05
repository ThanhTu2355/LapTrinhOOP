using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapTuLuyen05
{
    class QuanLyCD
    {
        private CD[] ds;
        private int n;

        public QuanLyCD()
        {
            ds = new CD[100];
            n = 0;
        }
        public QuanLyCD(int sophantu)
        {
            ds = new CD[sophantu];
            n = 0;
        }
        public void ThemCD(CD cd)
        {
            if(n>=ds.Length)
            {
                Console.WriteLine("Danh sach da day ");
            }
            else
            {
                if (!KiemTraTrungCD(cd.MaCD))
                    ds[n++] = cd;
                else
                {
                    Console.WriteLine("Trung ma CD");
                }
            }
        }
        private bool KiemTraTrungCD(int macd)
        {
            for(int i=0; i<n;i++)
            {
                if(ds[i].MaCD==macd)
                {
                    return true;
                }
            }
            return false;
        }
        public double TinhGiaTrungBinh()
        {
            double tonggia = 0;
            for(int i=0;i<n;i++)
            {
                tonggia += ds[i].GiaTien;
            }
            return tonggia / n;
        }
        public void XuatketQua()
        {
            Console.WriteLine("{0,10} {1,30} {2,30} {3,10} {4,15}", "MaCD", "Tua CD", "Ca si", "So bai hat", "Gia tien");
            for (int i=0;i<n;i++)
            {
                Console.WriteLine(ds[i].ToString());
            }
        }
        public void SapXepGiamGiaThanh()
        {
            CD tam;
            for (int i = 0; i< n;i ++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (ds[i].GiaTien < ds[j].GiaTien)
                    {
                        tam = ds[i];
                        ds[i] = ds[j];
                        ds[j] = tam;
                    }
                }
            }
        }
    }
}
