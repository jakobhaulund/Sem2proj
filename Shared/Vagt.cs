using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miljøfestivalen.Shared
{
	public class Vagt
	{
		public int vagt_id { get; set; }
		public string område { get; set; }
		public TimeOnly start_tid { get; set; }
		public TimeOnly slut_tid { get; set; }
		public string beskrivelse { get; set; }
		public string priotering { get; set; }
		public Boolean er_bemandet { get; set; }
		public int antal_personer { get; set; }
	}
}

