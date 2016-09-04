using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PHotelData.TestSuite
{
    [TestClass]
    public class PSelectHotel
    {
        [TestMethod]
        public HotelInfo GetHotelInfoByFirstName(string HotelName)
        {
            HotelDBImpl hotelDBImpl = new HotelDBImpl();
            return TranslateHotelInfo.PaserHotelInfo(hotelDBImpl.SelectHotel(HotelName));


        }
    }
}
