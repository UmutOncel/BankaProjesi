using Banka.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Calisanlar
{
    public class GuvenlikGorevlisi:Calisan
    {
        public GuvenlikGorevlisi():base(Gorev.GuvenlikGorevlisi)
        {
            
        }

        public override Calisan MoladanDon()
        {
            return this;
        }

        public override void MolayaCik(object value)
        {
            value = null;
        }
    }
}
