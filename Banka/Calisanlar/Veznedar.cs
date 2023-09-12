using Banka.Enums;
using Banka.Interfaces;
using Banka.Musteriler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Calisanlar
{
    public class Veznedar:Calisan, IVeznedar
    {
        private bool molayaCikabilir;
        private bool molaBittiMi;
        public Musteri Musteri { get; set; }
        public IslemTipi IslemTipi { get; set; }
        public IslemSonucu IslemSonucu { get; set; }
        public Veznedar():base(Gorev.Veznedar)
        {
            
        }

        public void MusteriyiCagirVeIsleminiYap(Musteri musteri) 
        {
            this.Musteri = musteri;
            IslemYap(musteri);
            MusteriyiSonucHakkindaBilgilendir(musteri);
            this.Musteri = null;
            if (molayaCikabilir)
            {
                MolayaCik(this);
                if (molaBittiMi)
                {
                    MoladanDon();
                }
            }
        }

        public void IslemYap(Musteri musteri) 
        {
            this.IslemTipi = musteri.IslemTipi;
        }

        public void MusteriyiSonucHakkindaBilgilendir(Musteri musteri) 
        {
            musteri.IslemSonucu = this.IslemSonucu;
        }

        public override void MolayaCik(object value)
        {
            value = null;
        }

        public override Veznedar MoladanDon()
        {
            return this;
        }
    }
}
