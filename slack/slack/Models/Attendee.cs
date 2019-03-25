using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace slack.Models
{
    public class Attendee
    {
        public int AttendeeId { get; set; }
        public string User { get; set; }
        public string FirstName {get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        [DisplayName("Seminar")]
        public string Seminarz { get; set; }
        
        public Seminar Seminar { get; set; }
     

    }
}