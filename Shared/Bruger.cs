﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miljøfestivalen.Shared
{
	public class Bruger
	{
        public Bruger() 
        {
        }
        public int bruger_id { get; set; }
        public string rolle { get; set; }
        public string fulde_navn { get; set; }
        public string email { get; set; }
        public int telefon_nummer { get; set; }
        public DateTime fødselsdag { get; set; }
        public string cpr_nummer { get; set; }
        public string brugernavn { get; set; }
        public string password { get; set; }
        public bool er_aktiv { get; set; }
        public bool er_blacklistet { get; set; }
    }
}

