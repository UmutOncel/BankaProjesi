using Banka.Enums;
using Banka.Interfaces;
using Banka.Musteriler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Banka
{
    public class Numarator:INumarator
    {
        private List<Fis> musteriFisListesi;
        public List<Fis> MusteriFisListesi
        {
            get { return musteriFisListesi; }
            set { musteriFisListesi = value; }
        }

        private List<Musteri> musteriler;
        public List<Musteri> Musteriler
        {
            get { return musteriler; }
            set { musteriler = value; }
        }

        string dosyaAdiFis = "MusteriFisListesi.json";
        string dosyaAdiMusteri = "Musteriler.json";

        public Numarator()
        {
            musteriFisListesi = new List<Fis>();
            musteriler = new List<Musteri>();
            if (File.Exists(dosyaAdiFis))
            {
                FisListesiniOku();
            }
            if (File.Exists(dosyaAdiMusteri))
            {
                MusteriListesiniOku();
            }
        }

        public Fis FisVer(Musteri musteri, int TcNo) 
        {
            Fis fis = new Fis(musteri, TcNo);
            FisSiraNoBelirle(musteri, fis);
            musteriFisListesi.Add(fis);
            return fis;
        }

        public void FisSiraNoBelirle(Musteri musteri, Fis fis) 
        {
            if (musteri.MusteriTipi == MusteriTipi.VIPMusteri)
            {
                fis.SiraNo = musteriler.Count + 501;
            }
            else
            {
                fis.SiraNo = musteriler.Count + 1;
            }
            musteriler.Add(musteri);
        }

        public void FisListesiKaydet() 
        {
            StreamWriter writer = new StreamWriter(dosyaAdiFis);
            writer.Write(JsonSerializer.Serialize(musteriFisListesi));
            writer.Close();
        }

        public void FisListesiniOku() 
        {
            StreamReader reader = new StreamReader(dosyaAdiFis);
            string json = reader.ReadToEnd();
            reader.Close();
            this.musteriFisListesi = JsonSerializer.Deserialize<List<Fis>>(json);
        }

        public void MusteriListesiKaydet()
        {
            StreamWriter writer = new StreamWriter(dosyaAdiMusteri);
            writer.Write(JsonSerializer.Serialize(musteriler));
            writer.Close();
        }

        public void MusteriListesiniOku()
        {
            StreamReader reader = new StreamReader(dosyaAdiMusteri);
            string json = reader.ReadToEnd();
            reader.Close();
            this.musteriler = JsonSerializer.Deserialize<List<Musteri>>(json);
        }
    }
}
