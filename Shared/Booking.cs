using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miljøfestivalen.Shared
{
	public class Booking
	{
		public int booking_id { get; set; }
		public Vagt vagt_id { get; set;}
		public Frivillig frivillig { get; set; }
	}
}

