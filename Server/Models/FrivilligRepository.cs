using System;
using Dapper;
using System.Linq;
using Npgsql;
using Miljøfestivalen.Shared;
using System.Diagnostics;
using System.Data;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.Extensions.DependencyInjection; 

namespace Server.Models
{
	public class FrivilligRepository : IFrivilligRepository
	{
		private string sql = "";

		private dBContext Context;

		public FrivilligRepository(dBContext context)
        {
            this.Context = context;
        }

		public async Task<IEnumerable<Bruger>> HentAlleBrugere()
		{
			sql = $"SELECT bruger_id AS \"BrugerId\", fulde_navn AS \"FuldeNavn\" FROM brugere;";

			var BrugerListe = await Context.Connection.QueryAsync<Bruger>(sql);
			return BrugerListe.ToList();
		}
	}
}


