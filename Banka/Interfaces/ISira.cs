using Banka.Musteriler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Interfaces
{
    public interface ISira
    {
        Fis MusteriSirasiniBelirle(Musteri musteri);
        void MusteriOncelikDurumunuBelirle(Musteri musteri);
        void BireyselIslemSirasiVer(Musteri musteri);
        void BireyselIslemBelirle(Musteri musteri);
    }
}
