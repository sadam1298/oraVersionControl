﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MNBArfolyam.Entities
{
    class RateData
    {
        DateTime Date { get; set; }
        string Currency { get; set; }
        decimal Value { get; set; }
    }
}
