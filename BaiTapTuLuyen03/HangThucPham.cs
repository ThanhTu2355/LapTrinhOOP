using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapTuLuyen03
{
    internal class HangThucPham
    {
        private string MaHang;
        private string TenHang;
        private int DonGia;
        private DateTime NgaySanXuat;
        private DateTime NgayHetHan;

        public HangThucPham()
        {

        }
        public HangThucPham(string MaHang,string TenHang,int DonGia,DateTime NgaySanXuat,DateTime NgayHetHan)
        {
            this.MaHang = MaHang;
            this.TenHang = TenHang;
            this.DonGia = DonGia;
            this.NgaySanXuat = NgaySanXuat;
            this.NgayHetHan = NgayHetHan;
        }
        public string maHang
        {
            set { MaHang = value; }
            get { return MaHang; }
        }
        public string tenHang
        {
            set { TenHang = value; }
            get { return TenHang; }
        }
        public int donGia
        {
            set { DonGia = value; }
            get { return DonGia; }
        }
        public DateTime ngaySanXuat
        {
            set { NgaySanXuat = value; }
            get { return NgaySanXuat; }
        }
        public DateTime ngayHetHan
        {
            set { NgayHetHan = value; }
            get { return NgayHetHan; }
        }
        public bool KiemTraHetHan()
        { 
            DateTime NgayHienTai= DateTime.Today;
            if(ngayHetHan > NgayHienTai)
            {
                return true;
            }
            return false;
        }
    }
}
