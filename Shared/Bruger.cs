using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miljøfestivalen.Shared
{
	public class Bruger
	{
        public string FuldeNavn { get; set; }
        public string Email { get; set; }
        public int TelefonNummer { get; set; }
        public DateOnly Fødselsdag { get; set; }

    }
}

