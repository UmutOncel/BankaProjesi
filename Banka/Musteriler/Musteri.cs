using Banka.Enums;
using Banka.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Musteriler
{
    public abstract class Musteri:IMusteri
    {
        public int TcNo { get; set; }
        public MusteriTipi MusteriTipi { get; set; }
        public Fis Fis { get; set; }
        public IslemSonucu IslemSonucu { get; set; }
        public IslemTipi IslemTipi { get; set; }
        public Musteri(MusteriTipi musteriTipi)
        {
            this.MusteriTipi = musteriTipi;
        }

        public void FisAl(Fis fis) 
        {
            this.Fis = fis;
        }
    }
}
