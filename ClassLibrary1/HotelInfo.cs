using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHotelInfoPojoData.Entity

{
    public class HotelInfo
    {

        public Int64 HotelId { get; set; }
        public string HotelName { get; set; }
        public string EmailId { get; set; }
        public string PhoneNumber { get; set; }

        public string City { get; set; }

        public int TotalRooms { get; set; }

        public int AvailableRooms { get; set; }

    }
}
