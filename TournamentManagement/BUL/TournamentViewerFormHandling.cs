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
		// Update a matchup (Score, winner, parent matchup)
		public void UpdateMatchupModel(MatchupModel m)
		{
			GlobalConfig.Connection.UpdateMatchup(m);
		}
	}
}
