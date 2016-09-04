
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data.Common;

namespace HotelBooking.Data
{
    public class HotelDBImpl
    {
        private const string DBName = "HotelDB";
        public void InsertCustomer(string FirstName, string LastName, string EmailId, string PhoneNumber)
        {
            DatabaseProviderFactory dbfactory = new DatabaseProviderFactory();
            Database defaultDB = dbfactory.CreateDefault();
            Database database = dbfactory.Create(DBName);
            DbCommand dbcommand = database.GetStoredProcCommand("spInsertCustomer");
            database.AddInParameter(dbcommand, "HotelId", System.Data.DbType.String, FirstName);
            database.AddInParameter(dbcommand, "HotelName", System.Data.DbType.String, LastName);
            database.AddInParameter(dbcommand, "EmailId", System.Data.DbType.String, EmailId);
            database.AddInParameter(dbcommand, "PhoneNumber", System.Data.DbType.String, PhoneNumber);
            database.AddInParameter(dbcommand, "City", System.Data.DbType.String, PhoneNumber);
            database.AddInParameter(dbcommand, "TotalRooms", System.Data.DbType.String, PhoneNumber);
            database.AddInParameter(dbcommand, "AvailableRooms", System.Data.DbType.String, PhoneNumber);

            database.ExecuteScalar(dbcommand);
        }

        public System.Data.DataSet SelectCusotmer(string firstName)
        {

            DatabaseProviderFactory dbfactory = new DatabaseProviderFactory();
            Database defaultDB = dbfactory.CreateDefault();
            Database database = dbfactory.Create(DBName);
            DbCommand dbcommand = database.GetStoredProcCommand("spselectCustomer");
            database.AddInParameter(dbcommand, "@FirstName", System.Data.DbType.String, firstName);
            return database.ExecuteDataSet(dbcommand);
        }
    }
}
