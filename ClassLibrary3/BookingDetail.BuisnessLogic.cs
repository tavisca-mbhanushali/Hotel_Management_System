using System;
using System.Data;
using PHotelInfoPojoData.Entity;
using HotelRegistration2.Data;
using HotelBooking1.Data;
using BookingDetailPojo;

namespace PHotelBooking.BuisnessLogic.HotelSearch
{
   public class BookingDetail
    {
        public static BookingDetailPojoClass GetBookingDetailsByBookingId(Int64 BookingId)
        {
            BookingDetailsDBImpl bookingdetailDBImpl = new BookingDetailsDBImpl();
            return TranslateHotelBooking.PaserBookingDetail(bookingdetailDBImpl.SelectBookingDetail(BookingId));


        }

    }
}
