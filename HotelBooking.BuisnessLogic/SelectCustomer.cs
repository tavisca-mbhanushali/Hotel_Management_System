using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelData.Entity;
using HotelBooking1.Data;

namespace HotelBooking1.BussinessLogic
{
    public class SelectCustomer
    {
        public Customer GetcustomerByFirstName(string firstName)
        {
            CustomerDBImpl customerDBImpl = new CustomerDBImpl();
            return TranslateCustomer.PaserCustomer(customerDBImpl.SelectCusotmer(firstName));
        }
    }
}
