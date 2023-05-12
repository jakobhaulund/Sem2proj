using System;
using Miljøfestivalen.Shared;

namespace Client.Services
{
	public interface IVagtService
	{
        Task<Vagt[]> HentAlleVagter();
    }
}

