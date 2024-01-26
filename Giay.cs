using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadOverride
{
    abstract internal class Giay
    {
        public string Ten { get; set; }
        public string ThuongHieu { get; set; }
        public int Size { get; set; }
        public double Gia { get; set; }

        public double GiamGia(int phanTram)
        {
            return this.Gia * phanTram / 100;
        }

        public double GiamGia(int phanTram, double soTien)
        {
            return this.Gia * phanTram / 100 + soTien;
        }

        abstract public double GiamGia();
    }
}
