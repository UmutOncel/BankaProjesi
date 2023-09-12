using Banka.Musteriler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Interfaces
{
    public interface INumarator
    {
        Fis FisVer(Musteri musteri, int TcNo);
        void FisSiraNoBelirle(Musteri musteri, Fis fis);
        void FisListesiKaydet();
        void FisListesiniOku();
        void MusteriListesiKaydet();
        void MusteriListesiniOku();
    }
}
