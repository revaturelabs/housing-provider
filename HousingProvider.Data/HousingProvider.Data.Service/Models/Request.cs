using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HousingProvider.Data.Service.Models
{
    public class Request
    {
        public string RequestTitle { get; set; }
        public string Description { get; set; }
        public DateTime RequestDate { get; set; }
        public DateTime RequestModifiedDate { get; set; }
        public string RequestorName { get; set; }
        public string RepresentitiveName { get; set; }
        public string Action { get; set; }
        public bool Urgent { get; set; }
        public bool Active { get; set; }
        public Property Property { get; set; }
        public RequestType RequesType { get; set; }
        public Status Status { get; set; }
    }
}
