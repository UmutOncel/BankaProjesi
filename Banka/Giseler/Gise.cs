using Banka.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Giseler
{
    public abstract class Gise
    {
        public GiseTipi GiseTipi { get; set; }
        public Gise(GiseTipi giseTipi)
        {
            this.GiseTipi = giseTipi;
        }
    }
}
