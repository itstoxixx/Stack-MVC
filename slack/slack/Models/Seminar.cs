using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace slack.Models
{
    public class Seminar
    {
        public int SeminarId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string location { get; set; }
        public DateTime SeminarDate { get; set; }
        public string Speaker { get; set; }
        public int Price { get; set; }
        
    }
}