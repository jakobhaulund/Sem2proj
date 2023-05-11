using System;
using System.Net.Http.Json;
using Miljøfestivalen.Shared;


namespace Client.Services
{
    
    public class BrugerService : IBrugerService
    {
        private readonly HttpClient HttpClient;
        public Task<Bruger[]?> HentAlleBrugere() 
        {
            var Resultat = HttpClient.GetFromJsonAsync<Bruger[]>("api/brugere");
            return Resultat;
        }
    }
}
