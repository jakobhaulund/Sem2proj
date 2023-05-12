using System;
using Miljøfestivalen.Shared;

namespace Server.Models
{
	public interface IVagtRepository
	{
        Task<IEnumerable<Vagt>> HentAlleVagter();
    }
}

