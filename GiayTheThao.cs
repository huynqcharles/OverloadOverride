using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadOverride
{
    internal class GiayTheThao : Giay
    {
        public override double GiamGia()
        {
            return this.Gia * 20 / 100;
        }
    }
}
