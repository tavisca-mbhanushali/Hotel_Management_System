using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingDetailPojo
{
    public class BookingDetailPojoClass
    {
        public Int64 BookingId { get; set; }

        public Int64 CustomerId { get; set; }

        public Int64 HotelId { get; set; }

        public DateTime CheckInDate { get; set; }

        public DateTime CheckOutDate { get; set; }
    }
}
