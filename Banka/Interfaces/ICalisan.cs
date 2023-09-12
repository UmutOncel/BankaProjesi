using Banka.Calisanlar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Interfaces
{
    public interface ICalisan
    {
        void MolayaCik(object value);
        Calisan MoladanDon();
    }
}
