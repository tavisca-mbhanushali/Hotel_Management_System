using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data.Common;


namespace HotelRegistration2.Data
{
    public class BookingDetailsDBImpl
    {
        private const string DBName = "HotelBookingMan";
        public void InsertBookingDetails(Int64 BookingId, Int64 CustomerId, Int64 HotelId, DateTime CheckInDate, DateTime CheckOutDate)
        {
            DatabaseProviderFactory dbfactory = new DatabaseProviderFactory();
            Database defaultDB = dbfactory.CreateDefault();
            Database database = dbfactory.Create(DBName);
            DbCommand dbcommand = database.GetStoredProcCommand("spBookingDetails");
            database.AddInParameter(dbcommand, "BookingId", System.Data.DbType.Int64, BookingId);
            database.AddInParameter(dbcommand, "CustomerId", System.Data.DbType.Int64, CustomerId);
            database.AddInParameter(dbcommand, "HotelId", System.Data.DbType.String, HotelId);
            database.AddInParameter(dbcommand, "CheckInDate", System.Data.DbType.DateTime, CheckInDate);
            database.AddInParameter(dbcommand, "CheckOutDate", System.Data.DbType.DateTime, CheckOutDate);

            database.ExecuteScalar(dbcommand);
        }

        public System.Data.DataSet SelectBookingDetail(Int64 BookingId)
        {

            DatabaseProviderFactory dbfactory = new DatabaseProviderFactory();
            Database defaultDB = dbfactory.CreateDefault();
            Database database = dbfactory.Create(DBName);
            DbCommand dbcommand = database.GetStoredProcCommand("spSelectBookingDetail_new");
            database.AddInParameter(dbcommand, "@BookingId", System.Data.DbType.String, BookingId);
            return database.ExecuteDataSet(dbcommand);
        }




    }
}
