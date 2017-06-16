using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>();
        public static void InitializeConnection(bool dataBase, bool textFiles)
        {
            if (dataBase == true)
            {
                //TODO - Setup the SQL connection properly
                Sqlconnector sql = new Sqlconnector();
                Connections.Add(sql);
            }
            if (textFiles == true)
            {
                //TODO - Create the text connection
                TextConnection text = new TextConnection();
                Connections.Add(text);
            }
        }
    }
}
