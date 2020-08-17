using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace BUL
{
	public class TournamentDashboardFormHandling
	{
		public List<TournamentModel> Get_All_Tournaments()
		{
			List<TournamentModel> T = DAL.GlobalConfig.Connection.Get_All_Tournaments();
			return T;
		}
	}
}
