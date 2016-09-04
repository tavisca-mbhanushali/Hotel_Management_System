using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelData.Entity;
using System.Data;

namespace HotelBooking.Data
{
    public static class TranslateCustomer
    {
        public static Hotel PaserCustomer(System.Data.DataSet customerdataset)
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
