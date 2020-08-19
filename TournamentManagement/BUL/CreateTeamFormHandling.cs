using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUL
{
	public class CreateTeamFormHandling
	{
        public CreateTeamFormHandling() { }
        
        // Insert a person
        public PersonModel CreatePerson(string firstName, string lastName, string emailAddress, string phoneNumber)
		{
            PersonModel model = new PersonModel();
            model.FirstName = firstName;
            model.LastName = lastName;
            model.EmailAddress = emailAddress;
            model.CellPhoneNumber = phoneNumber;

            // db ở đây chính là lớp SQLConnector mà từ lúc khởi động chương trình (program.cs) đã thêm vào lớp GlobalConfig

            DAL.GlobalConfig.Connection.CreatePeople(model);
            return model;

            /*
            foreach (SqlConnector db in GlobalConfig.Connections)
            {
                db.CreatePrize(model);
            }
            */
        }

        // Get all the members in team
        public List<PersonModel> Select_All_Persons()
        {
            List<PersonModel> output = DAL.GlobalConfig.Connection.Get_All_Persons();
            return output;
        }

        // Insert a team into db

        public TeamModel CreateTeam(TeamModel team_from_UI)
		{
            TeamModel t = DAL.GlobalConfig.Connection.CreateTeam(team_from_UI);
            return t;
		}
    }
}
