using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BUL
{
    public class CreatePrizeBUL
    {

        public CreatePrizeBUL(string placeName, int placeNumber, decimal prizeAmount, double prizePercentage)
		{
            
        }

        public CreatePrizeBUL() { }


        public PrizeModel CreatePrize(string placeName, int placeNumber, decimal prizeAmount, float prizePercentage)
		{
            PrizeModel model = new PrizeModel();
            model.PlaceName = placeName;
            model.PlaceNumber = placeNumber;
            model.PrizeAmount = prizeAmount;
            model.PrizePercentage = prizePercentage;

            // db ở đây chính là lớp SQLConnector mà từ lúc khởi động chương trình (program.cs) đã thêm vào lớp GlobalConfig

            DAL.GlobalConfig.Connection.CreatePrize(model);
            return model;

            /*
            foreach (SqlConnector db in GlobalConfig.Connections)
            {
                db.CreatePrize(model);
            }
            */
        }

    }
}
