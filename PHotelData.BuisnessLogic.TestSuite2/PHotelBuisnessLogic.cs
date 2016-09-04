using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HotelBooking1.BussinessLogic;
using PHotelInfoPojoData.Entity;

namespace PHotelData.BuisnessLogic.TestSuite2
{
    [TestClass]
    public class PHotelBuisnessLogic
    {
        [TestMethod]
        public void GetHotelInfoByFirstName()
        {
            PSelectHotel selectHotelInfo = new PSelectHotel();
            HotelInfo HotelInfodata = PSelectHotel.GetHotelInfoByFirstName("Hyatt");


        }
    }
}
