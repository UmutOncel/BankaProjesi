using Banka.Musteriler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Interfaces
{
    public interface IGunlukRapor
    {
        int GunlukVIPMusteriSayisiniBul(Musteri musteri);
        int GunlukBireyselIslemSayisiniBul(Musteri musteri);
        int GunlukGiselIslemiSayisiniBul(Musteri musteri);
    }
}
