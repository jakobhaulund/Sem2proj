using System;
using Miljøfestivalen.Shared;

namespace Server.Models
{
	public interface IFrivilligRepository
	{
		Task<IEnumerable<Bruger>> HentAlleBrugere();
	}
}

