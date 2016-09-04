using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelBooking1.Data;
using HotelRegistration2.Data;
using HotelBooking1.BussinessLogic;
using PHotelInfoPojoData.Entity;
using PHotelBooking.BuisnessLogic.HotelSearch;
using Logging_Files_HOBMAN;
//using NLog;
using log4net;
using log4net.Config;


namespace HotelBookingAPI
{
    class Program
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Program));
        static void Main(string[] args)
        {
            XmlConfigurator.Configure();
            log.Debug("Hello, Logsene!");
            log.Info("Hello, Logsene!");
            log.Warn("Hello, Logsene!");
            log.Error("Hello, Logsene!");

            try
            {

                Console.WriteLine("Enter Your Role");
                Console.WriteLine("1.Customer");
                Console.WriteLine("2.Agent");
                Console.WriteLine("3.Exit");

                int role;
                role = int.Parse(Console.ReadLine());

                Int64 HotelId;
                string HotelName;
                string City;
                Int64 TotalRooms;
                Int64 AvailabeRooms;

                string FirstName;
                string LastName;
                string EmailId;
                string PhoneNumber;

                Int64 BookingId;
                Int64 CustomerId;
                DateTime CheckInDate;
                DateTime CheckOutDate;


                do
                {
                    switch (role)
                    {
                        case 1:

                            Console.WriteLine("Welcome Customer");
                            Console.WriteLine("Enter Your Details");

                            Random random = new Random();
                            Int64 ID = random.Next();

                            Console.WriteLine("Enter Your First Name");
                            FirstName = Console.ReadLine();

                            Console.WriteLine("Enter Your Last Name");
                            LastName = Console.ReadLine();

                            Console.WriteLine("Enter Your Email Id");
                            EmailId = Console.ReadLine();

                            Console.WriteLine("Enter Your PhoneNumber");
                            PhoneNumber = Console.ReadLine();

                            CustomerDBImpl customerdbImple = new CustomerDBImpl();
                            customerdbImple.InsertCustomer(ID, FirstName, LastName, EmailId, PhoneNumber);

                            Console.WriteLine("Plz Note Down Your Customer Id :");
                            Console.WriteLine("Customer ID : {0} ", ID);


                            Int64 customerChoice;

                            do
                            {
                                Console.WriteLine("Welcome Customer ");
                                Console.WriteLine("Enter your Choice");
                                Console.WriteLine("1.Availabality in Hotel");
                                Console.WriteLine("2.Booking Room");
                                Console.WriteLine("3.Booking Details");
                                Console.WriteLine("4.Exit");


                                customerChoice = Int64.Parse(Console.ReadLine());

                                if (customerChoice == 1)
                                {
                                    Console.WriteLine("Enter Hotel Name to check Availablity");
                                    HotelName = Console.ReadLine();

                                    PSelectHotel selectHotelInfo = new PSelectHotel();
                                    HotelInfo HotelInfodata = PSelectHotel.GetHotelInfoByFirstName(HotelName);

                                    Console.WriteLine("Hotel ID " + "\t" + "Hotel Name" + "\t" + "Email Id" + "\t" + "Phone Number" + "\t" + "Total Rooms" + "\t" + "Available Rooms");
                                    Console.WriteLine(HotelInfodata.HotelId + "\t" + HotelInfodata.HotelName + "\t" + HotelInfodata.EmailId + "\t" + HotelInfodata.PhoneNumber + "\t" + HotelInfodata.TotalRooms + "\t" + HotelInfodata.AvailableRooms);





                                }
                                else if (customerChoice == 2)
                                {
                                    Console.WriteLine("Welcome to Booking Room");
                                    Console.WriteLine("Please Fill the booking details");

                                    Console.WriteLine("Enter Booking ID");
                                    BookingId = Int64.Parse(Console.ReadLine());

                                    Console.WriteLine("Enter Customer ID");
                                    CustomerId = Int64.Parse(Console.ReadLine());

                                    Console.WriteLine("Enter Hotel ID");
                                    HotelId = Int64.Parse(Console.ReadLine());
                                    if (HotelId % 2 == 0)
                                    {
                                        Console.WriteLine("Enter CheckInDate");
                                        CheckInDate = DateTime.Parse(Console.ReadLine());

                                        Console.WriteLine("Enter CheckOutDate");
                                        CheckOutDate = DateTime.Parse(Console.ReadLine());



                                        BookingDetailsDBImpl bookingDetailsDBImpl = new BookingDetailsDBImpl();
                                        bookingDetailsDBImpl.InsertBookingDetails(BookingId, CustomerId, HotelId, CheckInDate, CheckOutDate);

                                        //LogWriter logger = new LogWriter();

                                        //logger.search_hotel(ID, log);
                                        //logger.search_room(Cust_Id,roomid);
                                        log.InfoFormat("User has searched for hotel id {0}",HotelId);

                                        Console.WriteLine(" Room Booked successfully ");
                                    }
                                    else
                                    {
                                        throw new Exception("Hotel with Odd Hotel ID can not be booked");



                                    }

                                }
                                else if (customerChoice == 3)
                                {
                                    Console.WriteLine("Booking Details");



                                    Console.WriteLine("Enter Booking ID which you got at the time of booking");
                                    BookingId = Int64.Parse(Console.ReadLine());

                                    var bookingdata = BookingDetail.GetBookingDetailsByBookingId(BookingId);

                                    Console.WriteLine("Booking Id " + "\t" + "Customer Id" + "\t" + "Hotel Id" + "\t" + "CheckInDate" + "\t" + "CheckOutDate");
                                    Console.WriteLine(bookingdata.BookingId + "\t" + bookingdata.CustomerId + "\t" + bookingdata.HotelId + "\t" + bookingdata.CheckInDate + "\t" + bookingdata.CheckOutDate);




                                }

                                else if (customerChoice == 4)
                                {
                                    Console.WriteLine("Exit Successfuly");
                                    System.Environment.Exit(1);
                                }
                                else
                                {
                                    Console.WriteLine("Please Enter Correct Choice!");

                                }
                            } while (customerChoice != 4);

                            break;

                        case 2:
                            Int64 agentChoice;

                            do
                            {

                                Console.WriteLine("Welcome Agent");
                                Console.WriteLine("Enter your Choice");
                                Console.WriteLine("1.Add Hotel");
                                Console.WriteLine("2.Availabality in Hotel");
                                Console.WriteLine("3.Booking Room");
                                Console.WriteLine("4.Show Customer Details");
                                Console.WriteLine("5.Show Booking Details");
                                Console.WriteLine("6.Exit");

                                agentChoice = Int64.Parse(Console.ReadLine());

                                if (agentChoice == 1)
                                {
                                    Console.WriteLine("Welcome to Add Hotels ");

                                    Console.WriteLine("Enter Hotel ID");
                                    HotelId = Int64.Parse(Console.ReadLine());

                                    Console.WriteLine("Enter Hotel Name");
                                    HotelName = Console.ReadLine();

                                    Console.WriteLine("Enter Hotel Email Id");
                                    EmailId = Console.ReadLine();

                                    Console.WriteLine("Enter Hotel PhoneNumber");
                                    PhoneNumber = Console.ReadLine();

                                    Console.WriteLine("Enter Hotel City");
                                    City = Console.ReadLine();

                                    Console.WriteLine("Enter Total No Of Rooms in Hotel");
                                    TotalRooms = Int64.Parse(Console.ReadLine());

                                    Console.WriteLine("Enter Available Rooms in Hotel");
                                    AvailabeRooms = Int64.Parse(Console.ReadLine());


                                    HotelDBImpl hoteldbImple = new HotelDBImpl();
                                    hoteldbImple.InsertHotel(HotelId, HotelName, EmailId, PhoneNumber, City, TotalRooms, AvailabeRooms);

                                    Console.WriteLine(" Hotel Added successfully ");

                                }
                                else if (agentChoice == 2)
                                {
                                    Console.WriteLine("Enter Hotel Name to check Availablity");
                                    HotelName = Console.ReadLine();

                                    PSelectHotel selectHotelInfo = new PSelectHotel();
                                    HotelInfo HotelInfodata = PSelectHotel.GetHotelInfoByFirstName(HotelName);
                                    Console.WriteLine("Hotel ID " + "\t" + "Hotel Name" + "\t" + "Email Id" + "\t" + "Phone Number" + "\t" + "Total Rooms" + "\t" + "Available Rooms");
                                    Console.WriteLine(HotelInfodata.HotelId + "\t" + HotelInfodata.HotelName + "\t" + HotelInfodata.EmailId + "\t" + HotelInfodata.PhoneNumber + "\t" + HotelInfodata.TotalRooms + "\t" + HotelInfodata.AvailableRooms);
                                }
                                else if (agentChoice == 3)
                                {
                                    Console.WriteLine("Welcome to Booking Room");
                                    Console.WriteLine("Please Fill the booking details");

                                    Console.WriteLine("Enter Booking ID");
                                    BookingId = Int64.Parse(Console.ReadLine());

                                    Console.WriteLine("Enter Customer ID");
                                    CustomerId = Int64.Parse(Console.ReadLine());

                                    Console.WriteLine("Enter Hotel ID");
                                    HotelId = Int64.Parse(Console.ReadLine());

                                    Console.WriteLine("Enter CheckInDate");
                                    CheckInDate = DateTime.Parse(Console.ReadLine());

                                    Console.WriteLine("Enter CheckOutDate");
                                    CheckOutDate = DateTime.Parse(Console.ReadLine());


                                    BookingDetailsDBImpl bookingDetailsDBImpl = new BookingDetailsDBImpl();
                                    bookingDetailsDBImpl.InsertBookingDetails(BookingId, CustomerId, HotelId, CheckInDate, CheckOutDate);

                                    Console.WriteLine(" Room Booked successfully ");



                                }
                                else if (agentChoice == 4)
                                {
                                    Console.WriteLine("Welcome to Customer Details");

                                    Console.WriteLine("Enter Customer Name to check Details");
                                    FirstName = Console.ReadLine();

                                    SelectCustomer selectCustomer = new SelectCustomer();
                                    var customerdata = selectCustomer.GetcustomerByFirstName(FirstName);

                                    Console.WriteLine("Customer ID " + "\t" + "First Name" + "\t" + "Last Name" + "\t" + "Email Id" + "\t" + "Phone Number");
                                    Console.WriteLine(customerdata.Id + "\t" + customerdata.FirstName + "\t" + customerdata.LastName + "\t" + customerdata.EmailId + "\t" + customerdata.PhoneNumber);

                                }
                                else if (agentChoice == 5)
                                {
                                    Console.WriteLine("Booking Details");



                                    Console.WriteLine("Enter Booking ID which you got at the time of booking");
                                    BookingId = Int64.Parse(Console.ReadLine());

                                    var bookingdata = BookingDetail.GetBookingDetailsByBookingId(BookingId);

                                    Console.WriteLine("Booking Id " + "\t" + "Customer Id" + "\t" + "Hotel Id" + "\t" + "CheckInDate" + "\t" + "CheckOutDate");
                                    Console.WriteLine(bookingdata.BookingId + "\t" + bookingdata.CustomerId + "\t" + bookingdata.HotelId + "\t" + bookingdata.CheckInDate + "\t" + bookingdata.CheckOutDate);

                                }
                                else if (agentChoice == 6)
                                {
                                    Console.WriteLine("Exit Successfuly");
                                    System.Environment.Exit(1);


                                }
                                else
                                {
                                    Console.WriteLine("Please Enter Correct Choice!");

                                }

                            } while (agentChoice != 6);

                            break;

                        case 3:

                            Console.WriteLine("Welcome Again");
                            System.Environment.Exit(1);
                            break;

                        default:

                            Console.WriteLine("Wrong Input! Enter Again");

                            break;

                    }

                } while (role != 3);
            }
            catch(Exception e)
            {
                log.Error(e.Message);

            }

            
        }
    }
}
