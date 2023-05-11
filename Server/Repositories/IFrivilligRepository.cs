using System;
using Miljøfestivalen.Shared;

namespace Server.Repositories
{
	public interface IFrivilligRepository
	{
		IEnumerable<Bruger> GetBrugere();
	}
}

