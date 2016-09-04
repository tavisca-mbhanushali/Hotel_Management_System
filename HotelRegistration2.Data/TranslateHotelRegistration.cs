using System;
using System.Data;
using PHotelInfoPojoData.Entity;


namespace HotelBooking1.Data
{
    public static class TranslateHotelInfo
    {
        public static HotelInfo PaserHotelInfo(System.Data.DataSet hoteldataset)
        {
            if (hoteldataset == null)
                return null;
            if (hoteldataset.Tables.Count > 0)
            {
                if (hoteldataset.Tables[0].Rows.Count > 0)
                {
                    DataRow row = hoteldataset.Tables[0].Rows[0];
                    HotelInfo hotel = new HotelInfo();
                    hotel.HotelId = Convert.ToInt64(row["HotelId"]);
                    hotel.HotelName = row["HotelName"].ToString();
                    
                    hotel.EmailId = row["EmailId"].ToString();
                    hotel.PhoneNumber = row["PhoneNumber"].ToString();
                    hotel.City = row["City"].ToString();

                    hotel.TotalRooms = Convert.ToInt32(row["TotalRooms"]);
                    hotel.AvailableRooms = Convert.ToInt32(row["AvailableRooms"]);



                    return hotel;
                }
            }
            return null;
        }
    }
}