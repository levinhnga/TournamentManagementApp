﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUL
{
	public class CreateTournamentFormHandling
	{
		// Get all teams from sql;
		public List<TeamModel> Get_All_Teams()
		{
			List<TeamModel> t = DAL.GlobalConfig.Connection.Get_All_Teams();
			return t;
		}

		// Insert a tournament into db
		public void CreateTournament(TournamentModel model)
		{	
			DAL.GlobalConfig.Connection.CreateTournament(model);
		}
	}
}
