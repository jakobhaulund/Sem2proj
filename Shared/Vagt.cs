using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miljøfestivalen.Shared
{
	public class Vagt
	{
		public int VagtId { get; set; }
		public string Område { get; set; }
		public DateOnly Dato { get; set; }
		public TimeOnly StartTid { get; set; }
		public TimeOnly SlutTid { get; set; }
		public string Beskrivelse { get; set; }
		public string Prioritering { get; set; }
		public Boolean ErBemandet { get; set; }
	}
}

