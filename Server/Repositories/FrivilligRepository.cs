using System;
using Dapper;
using Npgsql;
using Miljøfestivalen.Shared;
using System.Diagnostics;
using System.Data;

namespace Server.Repositories
{
	public class FrivilligRepository : IFrivilligRepository
	{

       public IEnumerable<Bruger> GetBrugere()
       {
            string ConnString = "User ID=hrcbomrh;Password=czku8YaHYA3BBb7nRQgvRxrPZb2LoZGC;Host=dumbo.db.elephantsql.com;Port=5432;Database=hrcbomrh";
            string Sql = "SELECT fulde_navn AS FuldeNavn FROM Bruger";

            List<Bruger> brugere = new List<Bruger>();

            using (IDbConnection db = new NpgsqlConnection(ConnString))
            {
                brugere = db.Query<Bruger>(Sql).AsList();
            }
            return brugere;
       }
    }
}


