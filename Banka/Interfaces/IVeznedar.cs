using Banka.Musteriler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Interfaces
{
    public interface IVeznedar
    {
        void MusteriyiCagirVeIsleminiYap(Musteri musteri);
        void IslemYap(Musteri musteri);
        void MusteriyiSonucHakkindaBilgilendir(Musteri musteri);
    }
}
