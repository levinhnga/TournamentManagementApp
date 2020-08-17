using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
	public class PrizeModel
	{
		public int Id { get; set; }
		public int PlaceNumber { get; set; }
		public string PlaceName { get; set; }
		public decimal PrizeAmount { get; set; }
		public float PrizePercentage { get; set; }
	}
}
