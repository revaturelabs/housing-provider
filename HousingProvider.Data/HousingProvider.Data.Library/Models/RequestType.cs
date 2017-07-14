using System;
using System.Collections.Generic;

namespace HousingProvider.Data.Service.Models
{
    public partial class RequestType
    {
        public RequestType()
        {
            Request = new HashSet<Request>();
        }

        public int RequestTypeId { get; set; }
        public string RequestTypeDescription { get; set; }
        public bool Active { get; set; }

        public virtual ICollection<Request> Request { get; set; }
    }
}
