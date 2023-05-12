using System;
using Miljøfestivalen.Shared;

namespace Client.Services
{
    public interface IBrugerService 
    {
        Task<Bruger[]> HentAlleBrugere();
    }
}
