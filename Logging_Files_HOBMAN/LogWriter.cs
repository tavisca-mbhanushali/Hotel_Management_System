using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


namespace Logging_Files_HOBMAN
{
    public class LogWriter
    {

        public void search_logging(Log_Properties new_log)
        {
            File.AppendAllText(@"D:\" + "log.txt", new_log.message + new_log.logdate_time + "\n");

        }
        
                public void search_hotel(Int64 Customer_ID, Int64 Hotel_Id)
              {

            
                Log_Properties log_hotel = new Log_Properties();
                log_hotel.ID = Customer_ID;
                log_hotel.message = "Customer with customer id " + Customer_ID + "has searched for Hotel Id" + Hotel_Id + "Booked Room ";
                log_hotel.logdate_time = DateTime.Now;
                search_logging(log_hotel);
            
              }
       



        }
   
}
            
        
