using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadOverride
{
    internal class GiayDa : Giay
    {
        public override double GiamGia()
        {
            return this.Gia * 10 / 100;
        }
    }
}
