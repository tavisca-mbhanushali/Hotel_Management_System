using BookingDetailPojo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelRegistration2.Data
{
   public static class TranslateHotelBooking
    {


        public static BookingDetailPojoClass PaserBookingDetail(System.Data.DataSet BookingDetaildataset)
        {
            if (BookingDetaildataset == null)
                return null;
            if (BookingDetaildataset.Tables.Count > 0)
            {
                if (BookingDetaildataset.Tables[0].Rows.Count > 0)
                {
                    DataRow row = BookingDetaildataset.Tables[0].Rows[0];
                    BookingDetailPojoClass bookingdetail = new BookingDetailPojoClass();

                    bookingdetail.BookingId = Convert.ToInt64(row["BookingId"]);

                    bookingdetail.CustomerId = Convert.ToInt64(row["CustomerId"]);

                    bookingdetail.HotelId = Convert.ToInt64(row["HotelId"]);

                   

                    bookingdetail.CheckInDate =Convert.ToDateTime(row["CheckInDate"]);

                    bookingdetail.CheckOutDate = Convert.ToDateTime(row["CheckOutDate"]);




                    return bookingdetail;
                }
            }
            return null;
        }















    }
}
