using System;
using Miljøfestivalen.Shared;

namespace Server.Models
{
	public interface IBrugerRepository
	{
		Task<IEnumerable<Bruger>> HentAlleFrivillige();
	}
}

