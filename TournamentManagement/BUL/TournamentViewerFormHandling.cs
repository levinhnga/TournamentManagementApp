using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BUL
{
	public class TournamentViewerFormHandling
	{
		public void UpdateMatchupModel(MatchupModel m)
		{
			GlobalConfig.Connection.UpdateMatchup(m);
		}
	}
}
