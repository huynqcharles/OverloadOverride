using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadOverride
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GiayTheThao giayTheThao = new GiayTheThao();
            giayTheThao.Ten = "Nike";
            giayTheThao.ThuongHieu = "Nike";
            giayTheThao.Size = 42;
            giayTheThao.Gia = 1000000;

            GiayDa giayDa = new GiayDa();
            giayDa.Ten = "Giay Da";
            giayDa.ThuongHieu = "ABC";
            giayDa.Size = 42;
            giayDa.Gia = 3000000;

            Console.WriteLine(giayDa.GiamGia(20, 50000) + " VND");

            Console.ReadKey();
        }

    }

}
