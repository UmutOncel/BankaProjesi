using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Exceptions
{
    public class MusteriYokException:Exception
    {
        public MusteriYokException():base("Musteri Yok")
        {
            
        }

        public MusteriYokException(string mesaj):base(mesaj)
        {
            
        }
    }
}
