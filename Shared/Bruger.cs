using System;
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
        public string Rolle { get; set; }
        public string FuldeNavn { get; set; }
        public string Email { get; set; }
        public int TelefonNummer { get; set; }
        public DateOnly Fødselsdag { get; set; }
        public int CPRNummer { get; set; }
        public string Brugernavn { get; set; }
        public string Password { get; set; }
        public bool ErAktiv { get; set; }
        public bool ErBlacklistet { get; set; }
    }
}

