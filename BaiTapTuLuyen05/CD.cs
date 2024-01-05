using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapTuLuyen05
{
    class CD
    {
        private int macd;
        private string tuacd;
        private string casi;
        private int sobaihat;
        private int giatien;

        public CD()
        { 
        }
        public CD(int macd)
        {
            this.macd = macd;
        }
        public CD(int macd, string tuacd, string casi, int sobaihat, int giatien)
        {
            this.macd = macd;
            this.tuacd = tuacd;
            this.casi = casi;
            this.sobaihat = sobaihat;
            this.giatien = giatien;
        }
        public int MaCD
        {
            set { this.macd = value; }
            get { return macd; }
        }
        public string TuaCD
        {
            set { this.tuacd = value; }
            get { return tuacd; }
        }
        public string CaSi
        {
            set { this.casi = value; }
            get { return casi; }
        }
        public int SoBaiHat
        {
            set { this.sobaihat = value; }
            get { return sobaihat; }
        }
        public int GiaTien
        {
            set { this.giatien = value; }
            get { return giatien; }
        }
        public string ToString()
        {
            return string.Format("{0,10} {1,30} {2,30} {3,10} {4,15:#,##0}", macd, tuacd, casi, sobaihat, giatien);
        }
    }
}
