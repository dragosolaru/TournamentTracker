using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess
{
    public class Sqlconnector : IDataConnection
    {
        //TODO - Make the CreatePrize actually save to the dataBase
        /// <summary>
        /// Save a new prize to the dataBase
        /// </summary>
        /// <param name="model">The Prize Information</param>
        /// <returns>The prize information, including the ID (unique identifier)</returns>
        public PrizeModel CreatePrieze(PrizeModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Tournaments")))
            {
                var p = new DynamicParameters();
                p.Add("@PlaceNumber", model.PlaceNumber);
                p.Add("@PlaceName", model.PlaceName);
                p.Add("@PrizeAmount", model.PrizeAmount);
                p.Add("@PrizePercentage", model.PrizePercentage);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spPrizes_Insert", p, commandType: CommandType.StoredProcedure);

                model.ID = p.Get<int>("@id");

                return model;
            } 
        }
    }
}
