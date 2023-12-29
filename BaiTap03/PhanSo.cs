using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap03
{
    class PhanSo
    {
        private int tuso, mauso;

        public PhanSo()
        {
            tuso = 1;
            mauso = 2;
        }
        public PhanSo(int tuso, int mauso)
        {
            this.tuso = tuso;
            this.mauso = mauso;
        }
        public void setTuso(int tuso)
        {
            this.tuso = tuso;
        }
        public int getTuso() 
        {
            return tuso;
        }

        public void setMauuso(int mauso)
        {
            this.mauso = mauso;
        }
        public int getMauso()
        {
            return mauso;
        }
        public void ToiGian()
        {
            int uscln = USCLN(tuso,mauso);
            tuso = tuso/uscln;
            mauso = mauso/uscln;
        }
        public int USCLN(int a, int b)
        {
            int x = Math.Abs(a);
            int y = Math.Abs(b);
            while(x!=y)
            {
                if(x>y)
                {
                    x = x - y;
                }else
                {
                    y= y - x;
                }
            }    
            return x;
        }
        public PhanSo Cong(PhanSo ps)
        {
            PhanSo kq = new PhanSo();
            kq.tuso = tuso * ps.mauso + mauso * ps.tuso;
            kq.mauso = mauso * ps.mauso;
            return kq;
        }
        public PhanSo Tru(PhanSo ps)
        {
            PhanSo kq = new PhanSo();
            kq.tuso = tuso * ps.mauso - mauso * ps.tuso;
            kq.mauso = mauso * ps.mauso;
            return kq;
        }
        public PhanSo Nhan(PhanSo ps)
        {
            PhanSo kq = new PhanSo();
            kq.tuso = tuso * ps.tuso;
            kq.mauso = mauso * ps.mauso;
            return kq;
        }
        public PhanSo Chia(PhanSo ps)
        {
            PhanSo kq = new PhanSo();
            kq.tuso = tuso * ps.mauso;
            kq.mauso = mauso * ps.tuso;
            return kq;
        }
    }
    
}
