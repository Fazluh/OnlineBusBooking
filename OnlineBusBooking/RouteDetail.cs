//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class RouteDetail
    {
        public int RouteID { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> BusID { get; set; }
    }
}