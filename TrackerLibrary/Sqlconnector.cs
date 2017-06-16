using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
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
            model.ID = 1;

            return model;
        }
    }
}
