using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GigHub.ViewModels
{
    public class GigDetailsViewModel
    {
        public string Venue { get; set; }
        public DateTime DateTime { get; set; }
        public string Artist { get; set; }
        public bool IsAttending { get; set; }
        public bool IsFollowing { get; set; }
    }
}