using Banka.Enums;
using Banka.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Calisanlar
{
    public abstract class Calisan:ICalisan
    {
        public Gorev Gorev { get; set; }
        public Calisan(Gorev gorev)
        {
            this.Gorev = gorev;
        }

        public abstract void MolayaCik(object value);

        public abstract Calisan MoladanDon();
    }
}
