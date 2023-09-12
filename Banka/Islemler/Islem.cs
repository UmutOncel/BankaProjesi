using Banka.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Islemler
{
    public abstract class Islem
    {
        public IslemTipi IslemTipi { get; set; }
        public Islem(IslemTipi islemTipi)
        {
            this.IslemTipi = islemTipi;
        }
    }
}
