using System;

using HotelBooking1.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HotelBooking1.BussinessLogic;

namespace HotelData.BusinessLogic.TestSuite
{
    [TestClass]
    public class CustomerBussinesLogic
    {
        [TestMethod]
        public void SelectCustomers()
        {
            SelectCustomer selectCustomer = new SelectCustomer();
            var customerasda = selectCustomer.GetcustomerByFirstName("om");

         
        }
    }
}


