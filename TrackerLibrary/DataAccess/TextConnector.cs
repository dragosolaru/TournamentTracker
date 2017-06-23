using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess
{
    public class TextConnector : IDataConnection
    {
        //TODO - Wire up de CreatePrize  for text file
        public PrizeModel CreatePrieze(PrizeModel model)
        {
            model.ID = 1;

            return model;
        }
    }
}
