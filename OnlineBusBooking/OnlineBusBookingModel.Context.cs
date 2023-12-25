﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OnlineBusBooking
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class OnlineBusBookingEntities : DbContext
    {
        public OnlineBusBookingEntities()
            : base("name=OnlineBusBookingEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<BookingMaster> BookingMasters { get; set; }
        public virtual DbSet<BusMaster> BusMasters { get; set; }
        public virtual DbSet<CardDetail> CardDetails { get; set; }
        public virtual DbSet<CityDetail> CityDetails { get; set; }
        public virtual DbSet<PickUpStand> PickUpStands { get; set; }
        public virtual DbSet<PNRDetail> PNRDetails { get; set; }
        public virtual DbSet<Registration> Registrations { get; set; }
        public virtual DbSet<RouteDetail> RouteDetails { get; set; }
        public virtual DbSet<ScheduleMaster> ScheduleMasters { get; set; }
    
        public virtual int addBordingDetails(Nullable<int> routeID, string placeName, string placeTime, Nullable<int> busID)
        {
            var routeIDParameter = routeID.HasValue ?
                new ObjectParameter("RouteID", routeID) :
                new ObjectParameter("RouteID", typeof(int));
    
            var placeNameParameter = placeName != null ?
                new ObjectParameter("PlaceName", placeName) :
                new ObjectParameter("PlaceName", typeof(string));
    
            var placeTimeParameter = placeTime != null ?
                new ObjectParameter("PlaceTime", placeTime) :
                new ObjectParameter("PlaceTime", typeof(string));
    
            var busIDParameter = busID.HasValue ?
                new ObjectParameter("BusID", busID) :
                new ObjectParameter("BusID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("addBordingDetails", routeIDParameter, placeNameParameter, placeTimeParameter, busIDParameter);
        }
    
        public virtual ObjectResult<GetPassengerDetails_Result> GetPassengerDetails(string pNRNo)
        {
            var pNRNoParameter = pNRNo != null ?
                new ObjectParameter("PNRNo", pNRNo) :
                new ObjectParameter("PNRNo", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetPassengerDetails_Result>("GetPassengerDetails", pNRNoParameter);
        }
    
        public virtual int ispAddBusDetails(string busNo, string bustType, Nullable<int> seatColumn, Nullable<int> seatRow, string origin, string destination, string busName)
        {
            var busNoParameter = busNo != null ?
                new ObjectParameter("BusNo", busNo) :
                new ObjectParameter("BusNo", typeof(string));
    
            var bustTypeParameter = bustType != null ?
                new ObjectParameter("BustType", bustType) :
                new ObjectParameter("BustType", typeof(string));
    
            var seatColumnParameter = seatColumn.HasValue ?
                new ObjectParameter("SeatColumn", seatColumn) :
                new ObjectParameter("SeatColumn", typeof(int));
    
            var seatRowParameter = seatRow.HasValue ?
                new ObjectParameter("SeatRow", seatRow) :
                new ObjectParameter("SeatRow", typeof(int));
    
            var originParameter = origin != null ?
                new ObjectParameter("Origin", origin) :
                new ObjectParameter("Origin", typeof(string));
    
            var destinationParameter = destination != null ?
                new ObjectParameter("Destination", destination) :
                new ObjectParameter("Destination", typeof(string));
    
            var busNameParameter = busName != null ?
                new ObjectParameter("BusName", busName) :
                new ObjectParameter("BusName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ispAddBusDetails", busNoParameter, bustTypeParameter, seatColumnParameter, seatRowParameter, originParameter, destinationParameter, busNameParameter);
        }
    
        public virtual int ispAddBusSchedule(string date, Nullable<int> busID, Nullable<decimal> fare, string estimatdTime, string arrivalTime, string departureTime, Nullable<int> routeID)
        {
            var dateParameter = date != null ?
                new ObjectParameter("Date", date) :
                new ObjectParameter("Date", typeof(string));
    
            var busIDParameter = busID.HasValue ?
                new ObjectParameter("BusID", busID) :
                new ObjectParameter("BusID", typeof(int));
    
            var fareParameter = fare.HasValue ?
                new ObjectParameter("Fare", fare) :
                new ObjectParameter("Fare", typeof(decimal));
    
            var estimatdTimeParameter = estimatdTime != null ?
                new ObjectParameter("EstimatdTime", estimatdTime) :
                new ObjectParameter("EstimatdTime", typeof(string));
    
            var arrivalTimeParameter = arrivalTime != null ?
                new ObjectParameter("ArrivalTime", arrivalTime) :
                new ObjectParameter("ArrivalTime", typeof(string));
    
            var departureTimeParameter = departureTime != null ?
                new ObjectParameter("DepartureTime", departureTime) :
                new ObjectParameter("DepartureTime", typeof(string));
    
            var routeIDParameter = routeID.HasValue ?
                new ObjectParameter("RouteID", routeID) :
                new ObjectParameter("RouteID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ispAddBusSchedule", dateParameter, busIDParameter, fareParameter, estimatdTimeParameter, arrivalTimeParameter, departureTimeParameter, routeIDParameter);
        }
    
        public virtual int ispAddCardDetails(Nullable<int> userID, string cardType, string bankName, string cVVNo, string cardNo, Nullable<decimal> totalAmount)
        {
            var userIDParameter = userID.HasValue ?
                new ObjectParameter("UserID", userID) :
                new ObjectParameter("UserID", typeof(int));
    
            var cardTypeParameter = cardType != null ?
                new ObjectParameter("CardType", cardType) :
                new ObjectParameter("CardType", typeof(string));
    
            var bankNameParameter = bankName != null ?
                new ObjectParameter("BankName", bankName) :
                new ObjectParameter("BankName", typeof(string));
    
            var cVVNoParameter = cVVNo != null ?
                new ObjectParameter("CVVNo", cVVNo) :
                new ObjectParameter("CVVNo", typeof(string));
    
            var cardNoParameter = cardNo != null ?
                new ObjectParameter("CardNo", cardNo) :
                new ObjectParameter("CardNo", typeof(string));
    
            var totalAmountParameter = totalAmount.HasValue ?
                new ObjectParameter("TotalAmount", totalAmount) :
                new ObjectParameter("TotalAmount", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ispAddCardDetails", userIDParameter, cardTypeParameter, bankNameParameter, cVVNoParameter, cardNoParameter, totalAmountParameter);
        }
    
        public virtual int ispAddPassengerDetails(Nullable<int> regId, Nullable<int> busId, string fname, string lname, string email, string contact, string city, string seatNo, string travelDate, string origin, string destination, Nullable<int> boardingId, Nullable<decimal> fare, Nullable<int> totalSeats, string pNRNo)
        {
            var regIdParameter = regId.HasValue ?
                new ObjectParameter("RegId", regId) :
                new ObjectParameter("RegId", typeof(int));
    
            var busIdParameter = busId.HasValue ?
                new ObjectParameter("BusId", busId) :
                new ObjectParameter("BusId", typeof(int));
    
            var fnameParameter = fname != null ?
                new ObjectParameter("Fname", fname) :
                new ObjectParameter("Fname", typeof(string));
    
            var lnameParameter = lname != null ?
                new ObjectParameter("Lname", lname) :
                new ObjectParameter("Lname", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var contactParameter = contact != null ?
                new ObjectParameter("Contact", contact) :
                new ObjectParameter("Contact", typeof(string));
    
            var cityParameter = city != null ?
                new ObjectParameter("City", city) :
                new ObjectParameter("City", typeof(string));
    
            var seatNoParameter = seatNo != null ?
                new ObjectParameter("SeatNo", seatNo) :
                new ObjectParameter("SeatNo", typeof(string));
    
            var travelDateParameter = travelDate != null ?
                new ObjectParameter("TravelDate", travelDate) :
                new ObjectParameter("TravelDate", typeof(string));
    
            var originParameter = origin != null ?
                new ObjectParameter("Origin", origin) :
                new ObjectParameter("Origin", typeof(string));
    
            var destinationParameter = destination != null ?
                new ObjectParameter("Destination", destination) :
                new ObjectParameter("Destination", typeof(string));
    
            var boardingIdParameter = boardingId.HasValue ?
                new ObjectParameter("BoardingId", boardingId) :
                new ObjectParameter("BoardingId", typeof(int));
    
            var fareParameter = fare.HasValue ?
                new ObjectParameter("Fare", fare) :
                new ObjectParameter("Fare", typeof(decimal));
    
            var totalSeatsParameter = totalSeats.HasValue ?
                new ObjectParameter("TotalSeats", totalSeats) :
                new ObjectParameter("TotalSeats", typeof(int));
    
            var pNRNoParameter = pNRNo != null ?
                new ObjectParameter("PNRNo", pNRNo) :
                new ObjectParameter("PNRNo", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ispAddPassengerDetails", regIdParameter, busIdParameter, fnameParameter, lnameParameter, emailParameter, contactParameter, cityParameter, seatNoParameter, travelDateParameter, originParameter, destinationParameter, boardingIdParameter, fareParameter, totalSeatsParameter, pNRNoParameter);
        }
    
        public virtual int ispAddPNRDetails(string pNRNo, Nullable<decimal> totalAmount, Nullable<int> totalTicket, Nullable<int> createdBy)
        {
            var pNRNoParameter = pNRNo != null ?
                new ObjectParameter("PNRNo", pNRNo) :
                new ObjectParameter("PNRNo", typeof(string));
    
            var totalAmountParameter = totalAmount.HasValue ?
                new ObjectParameter("TotalAmount", totalAmount) :
                new ObjectParameter("TotalAmount", typeof(decimal));
    
            var totalTicketParameter = totalTicket.HasValue ?
                new ObjectParameter("TotalTicket", totalTicket) :
                new ObjectParameter("TotalTicket", typeof(int));
    
            var createdByParameter = createdBy.HasValue ?
                new ObjectParameter("CreatedBy", createdBy) :
                new ObjectParameter("CreatedBy", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ispAddPNRDetails", pNRNoParameter, totalAmountParameter, totalTicketParameter, createdByParameter);
        }
    
        public virtual ObjectResult<ispGetAvailableBusDetails_Result> ispGetAvailableBusDetails(string origin, string destination, string travelDate)
        {
            var originParameter = origin != null ?
                new ObjectParameter("Origin", origin) :
                new ObjectParameter("Origin", typeof(string));
    
            var destinationParameter = destination != null ?
                new ObjectParameter("Destination", destination) :
                new ObjectParameter("Destination", typeof(string));
    
            var travelDateParameter = travelDate != null ?
                new ObjectParameter("TravelDate", travelDate) :
                new ObjectParameter("TravelDate", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ispGetAvailableBusDetails_Result>("ispGetAvailableBusDetails", originParameter, destinationParameter, travelDateParameter);
        }
    
        public virtual ObjectResult<ispGetBoardingPoints_Result> ispGetBoardingPoints(Nullable<int> busID)
        {
            var busIDParameter = busID.HasValue ?
                new ObjectParameter("BusID", busID) :
                new ObjectParameter("BusID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ispGetBoardingPoints_Result>("ispGetBoardingPoints", busIDParameter);
        }
    
        public virtual ObjectResult<string> ispGetBookedSeatNo(Nullable<int> busID, string travelDate)
        {
            var busIDParameter = busID.HasValue ?
                new ObjectParameter("BusID", busID) :
                new ObjectParameter("BusID", typeof(int));
    
            var travelDateParameter = travelDate != null ?
                new ObjectParameter("TravelDate", travelDate) :
                new ObjectParameter("TravelDate", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("ispGetBookedSeatNo", busIDParameter, travelDateParameter);
        }
    
        public virtual ObjectResult<ispGetBookingReportByAdmin_Result> ispGetBookingReportByAdmin()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ispGetBookingReportByAdmin_Result>("ispGetBookingReportByAdmin");
        }
    
        public virtual ObjectResult<ispGetBusDataByBusID_Result> ispGetBusDataByBusID(Nullable<int> busID)
        {
            var busIDParameter = busID.HasValue ?
                new ObjectParameter("BusID", busID) :
                new ObjectParameter("BusID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ispGetBusDataByBusID_Result>("ispGetBusDataByBusID", busIDParameter);
        }
    
        public virtual ObjectResult<ispGetBusDetailsForUpdation_Result> ispGetBusDetailsForUpdation()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ispGetBusDetailsForUpdation_Result>("ispGetBusDetailsForUpdation");
        }
    
        public virtual ObjectResult<ispGetCity_Result> ispGetCity()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ispGetCity_Result>("ispGetCity");
        }
    
        public virtual ObjectResult<ispGetPNRDetails_Result> ispGetPNRDetails(Nullable<int> userID)
        {
            var userIDParameter = userID.HasValue ?
                new ObjectParameter("UserID", userID) :
                new ObjectParameter("UserID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ispGetPNRDetails_Result>("ispGetPNRDetails", userIDParameter);
        }
    
        public virtual ObjectResult<ispGetRouteDetails_Result> ispGetRouteDetails()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ispGetRouteDetails_Result>("ispGetRouteDetails");
        }
    
        public virtual int ispUpdateBusData(Nullable<int> busID, string busNo, string busType, Nullable<int> seatColumn, Nullable<int> seatRow, string busName, string origin, string destination)
        {
            var busIDParameter = busID.HasValue ?
                new ObjectParameter("BusID", busID) :
                new ObjectParameter("BusID", typeof(int));
    
            var busNoParameter = busNo != null ?
                new ObjectParameter("BusNo", busNo) :
                new ObjectParameter("BusNo", typeof(string));
    
            var busTypeParameter = busType != null ?
                new ObjectParameter("BusType", busType) :
                new ObjectParameter("BusType", typeof(string));
    
            var seatColumnParameter = seatColumn.HasValue ?
                new ObjectParameter("seatColumn", seatColumn) :
                new ObjectParameter("seatColumn", typeof(int));
    
            var seatRowParameter = seatRow.HasValue ?
                new ObjectParameter("SeatRow", seatRow) :
                new ObjectParameter("SeatRow", typeof(int));
    
            var busNameParameter = busName != null ?
                new ObjectParameter("BusName", busName) :
                new ObjectParameter("BusName", typeof(string));
    
            var originParameter = origin != null ?
                new ObjectParameter("Origin", origin) :
                new ObjectParameter("Origin", typeof(string));
    
            var destinationParameter = destination != null ?
                new ObjectParameter("Destination", destination) :
                new ObjectParameter("Destination", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ispUpdateBusData", busIDParameter, busNoParameter, busTypeParameter, seatColumnParameter, seatRowParameter, busNameParameter, originParameter, destinationParameter);
        }
    
        public virtual ObjectResult<ispUserLogin_Result> ispUserLogin(string mobileNo, string password)
        {
            var mobileNoParameter = mobileNo != null ?
                new ObjectParameter("MobileNo", mobileNo) :
                new ObjectParameter("MobileNo", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("Password", password) :
                new ObjectParameter("Password", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ispUserLogin_Result>("ispUserLogin", mobileNoParameter, passwordParameter);
        }
    
        public virtual int ispUserRegistration(string fName, string lName, string emailId, string address, string city, string pinCode, string contactNo, string password, ObjectParameter ret_Val)
        {
            var fNameParameter = fName != null ?
                new ObjectParameter("FName", fName) :
                new ObjectParameter("FName", typeof(string));
    
            var lNameParameter = lName != null ?
                new ObjectParameter("LName", lName) :
                new ObjectParameter("LName", typeof(string));
    
            var emailIdParameter = emailId != null ?
                new ObjectParameter("EmailId", emailId) :
                new ObjectParameter("EmailId", typeof(string));
    
            var addressParameter = address != null ?
                new ObjectParameter("Address", address) :
                new ObjectParameter("Address", typeof(string));
    
            var cityParameter = city != null ?
                new ObjectParameter("City", city) :
                new ObjectParameter("City", typeof(string));
    
            var pinCodeParameter = pinCode != null ?
                new ObjectParameter("PinCode", pinCode) :
                new ObjectParameter("PinCode", typeof(string));
    
            var contactNoParameter = contactNo != null ?
                new ObjectParameter("ContactNo", contactNo) :
                new ObjectParameter("ContactNo", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("Password", password) :
                new ObjectParameter("Password", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ispUserRegistration", fNameParameter, lNameParameter, emailIdParameter, addressParameter, cityParameter, pinCodeParameter, contactNoParameter, passwordParameter, ret_Val);
        }
    }
}
