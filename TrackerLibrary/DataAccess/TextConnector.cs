using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;
using TrackerLibrary.DataAccess.TextHellpers;

namespace TrackerLibrary.DataAccess
{
    public class TextConnector : IDataConnection
    {
        private const string PrizesFile = "PrizeModels.csv";
        //TODO - Wire up de CreatePrize  for text file
        public PrizeModel CreatePrieze(PrizeModel model)
        {
            //Load text file (1) -defined in TextConnectorProcessor.cs
            //Convert text to list<PrizeModel>
            List<PrizeModel>prizes= PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModels();

            //fiind the max ID
            int currentId = 1;
            if (prizes.Count>0)
            {
               currentId=prizes.OrderByDescending(x => x.ID).First().ID + 1;
            }
            model.ID = currentId;

            //Add new record with new ID (here because is not Database Table, we nees to create manualy new ID) max+1
            prizes.Add(model);

            //Convert the prizes to list<string>
            //save list<string> to text file
            prizes.SaveToPrizeFile(PrizesFile);

            return model;

        }
    }
}
