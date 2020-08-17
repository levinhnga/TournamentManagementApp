using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUL
{
	public class InitializeConnections
	{
		// Call the method initializeConnection in GlobalConfig file
		public void InitializeConnection()
		{
			DAL.GlobalConfig.InitializeConnection(DAL.DatabaseType.Sql);
		}
	}
}
