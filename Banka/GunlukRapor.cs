using Banka.Enums;
using Banka.Interfaces;
using Banka.Musteriler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka
{
    public class GunlukRapor:IGunlukRapor
    {
        private List<Fis> _musteriFisListesi;
        private List<Musteri> _musteriler;

        public GunlukRapor(Numarator numarator)
        {
            _musteriFisListesi = numarator.MusteriFisListesi;
            _musteriler = numarator.Musteriler;
        }

        public int GunlukVIPMusteriSayisiniBul(Musteri musteri) 
        {
            int vipMusteriSayisi = 0;
            for (int i = 0; i < _musteriler.Count; i++)
            {
                if (musteri.MusteriTipi == MusteriTipi.VIPMusteri)
                {
                    vipMusteriSayisi++;
                }
            }
            return vipMusteriSayisi;
        }

        public int GunlukBireyselIslemSayisiniBul(Musteri musteri)
        {
            int bireyselIslemSayisi = 0;
            for (int i = 0; i < _musteriFisListesi.Count; i++)
            {
                if (musteri.IslemTipi == IslemTipi.BireyselIslem)
                {
                    bireyselIslemSayisi++;
                }
            }
            return bireyselIslemSayisi;
        }

        public int GunlukGiselIslemiSayisiniBul(Musteri musteri)
        {
            int giseIslemiSayisi = 0;
            for (int i = 0; i < _musteriFisListesi.Count; i++)
            {
                if (musteri.IslemTipi == IslemTipi.GiseIslemi)
                {
                    giseIslemiSayisi++;
                }
            }
            return giseIslemiSayisi;
        }
    }
}
