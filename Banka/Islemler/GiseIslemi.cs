﻿using Banka.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Islemler
{
    public class GiseIslemi:Islem
    {
        public GiseIslemi():base(IslemTipi.GiseIslemi)
        {
            
        }
    }
}
