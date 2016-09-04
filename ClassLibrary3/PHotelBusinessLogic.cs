using PHotelInfoPojoData.Entity;
using HotelRegistration2.Data;
using HotelBooking1.Data;

namespace HotelBooking1.BussinessLogic
{
    public class PSelectHotel
    {
        public static HotelInfo GetHotelInfoByFirstName(string HotelName)
        {
            HotelDBImpl hotelDBImpl = new HotelDBImpl();
            return TranslateHotelInfo.PaserHotelInfo(hotelDBImpl.SelectHotel(HotelName));

           
        }
    }
}