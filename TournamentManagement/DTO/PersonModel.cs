using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
	public class PersonModel
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string EmailAddress { get; set; }
		public string CellPhoneNumber { get; set; }
		public int Id { get; set; }

		public string FullName
		{
			get
			{
				return $"{ FirstName } { LastName }";
			}
		}
	}
}
