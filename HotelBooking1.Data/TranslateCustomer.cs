using System;
using System.Data;
using HotelData.Entity;


namespace HotelBooking1.Data
{
    public static class TranslateCustomer
    {
        public static Customer PaserCustomer(System.Data.DataSet customerdataset)
        {
            if (customerdataset == null)
                return null;
            if (customerdataset.Tables.Count > 0)
            {
                if (customerdataset.Tables[0].Rows.Count > 0)
                {
                    DataRow row = customerdataset.Tables[0].Rows[0];
                    Customer customer = new Customer();
                    customer.Id = Convert.ToInt32(row["Id"]);
                    customer.FirstName = row["FirstName"].ToString();
                    customer.LastName = row["LastName"].ToString();
                    customer.EmailId = row["EmailId"].ToString();
                    customer.PhoneNumber = row["PhoneNumber"].ToString();
                    return customer;
                }
            }
            return null;
        }
    }
}
