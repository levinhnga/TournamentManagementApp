using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
	public interface IDataConnection
	{
		

		PrizeModel CreatePrize(PrizeModel model);
		PersonModel CreatePeople(PersonModel model);
		TeamModel CreateTeam(TeamModel model);
		void CreateTournament(TournamentModel model);

		void CompleteTournament(TournamentModel model);
		void UpdateMatchup(MatchupModel model);
		List<TeamModel> Get_All_Teams();
		List<PersonModel> Get_All_Persons();
		List<TournamentModel> Get_All_Tournaments();
	}
}
