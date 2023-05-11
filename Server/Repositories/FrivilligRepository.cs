using System;
using Dapper;
using Npgsql;
using Miljøfestivalen.Shared;

namespace Server.Repositories
{
	public class FrivilligRepository : IFrivilligRepository
	{

       public IEnumerable<Bruger> GetBrugere()
       {
            var ConnString = "UserID=hrcbomrh;Password=czku8YaHYA3BBb7nRQgvRxrPZb2LoZGC;Host=dumbo.db.elephantsql.com;Port=5432;Database=hrcbomrh;";

            var Sql = "SELECT * FROM bruger";

            var brugere = new List<Bruger>();

            using (var connection = new NpgsqlConnection(ConnString))
            {
                    brugere = connection.Query<Bruger>(Sql).ToList();
            }

            return brugere;
       }
    }
}


