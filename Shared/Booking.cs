﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miljøfestivalen.Shared
{
	public class Booking
	{
		public int BookingId { get; set; }
		public Vagt Vagt { get; set;}
		public Frivillig Frivillig { get; set; }
	}
}

