using Banka.Musteriler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka
{
    public class Fis
    {
        public Musteri Musteri { get; set; }
        public int SiraNo { get; set; }
        public Fis(Musteri musteri, int TcNo)
        {
            musteri.TcNo = TcNo;
            this.Musteri = musteri;
            this.Musteri.Fis = this;
        }
    }
}
