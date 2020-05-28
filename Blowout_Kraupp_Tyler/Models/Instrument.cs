using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Blowout_Kraupp_Tyler.Models
{
    public class Instrument
    {
        [DisplayName("Instrument ID")]
        public int InstrumentID { get; set; }

        [DisplayName("Instrument Description")]
        public string Description { get; set; }

        [DisplayName("Instrument Type")]
        public string Type { get; set; }

        [DisplayName("Price")]
        public string Price { get; set; }
    }
}