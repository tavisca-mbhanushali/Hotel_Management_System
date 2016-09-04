using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data.Common;

namespace HotelRegistration2.Data
{
    public class HotelDBImpl
    {

        private const string DBName = "HotelBookingMan";
        public void InsertHotel(Int64 HotelID,string HotelName, string EmailId, string PhoneNumber, string City,Int64 TotalRooms,Int64 AvailableRooms)
        {
            DatabaseProviderFactory dbfactory = new DatabaseProviderFactory();
            Database defaultDB = dbfactory.CreateDefault();
            Database database = dbfactory.Create(DBName);
            DbCommand dbcommand = database.GetStoredProcCommand("spInsertHotel");
            database.AddInParameter(dbcommand, "HotelID", System.Data.DbType.Int64, HotelID);
            database.AddInParameter(dbcommand, "HotelName", System.Data.DbType.String, HotelName);
            database.AddInParameter(dbcommand, "EmailId", System.Data.DbType.String, EmailId);
            database.AddInParameter(dbcommand, "PhoneNumber", System.Data.DbType.String, PhoneNumber);
            database.AddInParameter(dbcommand, "City", System.Data.DbType.String, City);
            database.AddInParameter(dbcommand, "TotalRooms", System.Data.DbType.Int64, TotalRooms);
            database.AddInParameter(dbcommand, "AvailableRooms", System.Data.DbType.Int64, AvailableRooms);

            database.ExecuteScalar(dbcommand);
        }

        public System.Data.DataSet SelectHotel(string firstName)
        {

            DatabaseProviderFactory dbfactory = new DatabaseProviderFactory();
            Database defaultDB = dbfactory.CreateDefault();
            Database database = dbfactory.Create(DBName);
            DbCommand dbcommand = database.GetStoredProcCommand("spSelectHotel");
            database.AddInParameter(dbcommand, "@HotelName", System.Data.DbType.String, firstName);
            return database.ExecuteDataSet(dbcommand);
        }

    }
}





