using System;
using Miljøfestivalen.Shared;

namespace Server.Models
{
	public interface IBookingRepository 
	{
        Task<IEnumerable<Booking>> HentAlleBookinger();
    }
}

