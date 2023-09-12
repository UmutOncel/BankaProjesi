using Banka.Enums;
using Banka.Exceptions;
using Banka.Interfaces;
using Banka.Musteriler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka
{
    public class Sira:ISira
    {
        private List<Fis> siraListesi;
        public Sira(Numarator numarator)
        {
            siraListesi = numarator.MusteriFisListesi;
        }

        public Fis MusteriSirasiniBelirle(Musteri musteri) 
        {
            if (siraListesi.Count == 0)
            {
                throw new MusteriYokException();
            }
            else
            {
                BireyselIslemSirasiVer(musteri);
                MusteriOncelikDurumunuBelirle(musteri);
                Fis fis = siraListesi[0];
                siraListesi.Remove(fis);
                return fis;
            }
        }

        public void MusteriOncelikDurumunuBelirle(Musteri musteri) 
        {
            if (musteri.MusteriTipi == MusteriTipi.VIPMusteri)
            {
                siraListesi[0] = musteri.Fis;
            }
            else
            {
                throw new MusteriYokException("VIP Musteri Yok");
            }
        }

        public void BireyselIslemSirasiVer(Musteri musteri) 
        {
            if (siraListesi.Count % 4 == 0)
            {
                BireyselIslemBelirle(musteri);
            }
        }

        public void BireyselIslemBelirle(Musteri musteri) 
        {
            foreach (var item in siraListesi)
            {
                if (item.Musteri.IslemTipi == IslemTipi.BireyselIslem && musteri.MusteriTipi == MusteriTipi.VIPMusteri)
                {
                    siraListesi[0] = item;
                }
                else if (item.Musteri.IslemTipi == IslemTipi.BireyselIslem)
                {
                    siraListesi[0] = item;
                }
                else
                {
                    throw new MusteriYokException("Bireysel Islemi Olan Musteri Yok");
                }
            }
        }
    }
}
