using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HotelRegistration2.Data;
namespace PHotelData.TestSuite2
{
    [TestClass]
    public class PHotelDataHotelInfoTest
    {
        [TestMethod]
        public void insert()
        {
            HotelDBImpl hoteldbImple = new HotelDBImpl();
            hoteldbImple.InsertHotel(54, "Novotal", "mbhanushali@tavisca.com", "1234567890","Pune",100,50);

        }
    }
}

