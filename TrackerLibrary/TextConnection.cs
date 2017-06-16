using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class TextConnection : IDataConnection
    {
        //TODO - Wire up de CreatePrize  for text file
        public PrizeModel CreatePrieze(PrizeModel model)
        {
            model.ID = 1;

            return model;
        }
    }
}
