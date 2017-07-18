using System;
using System.Collections.Generic;

namespace HousingProvider.Data.Library.EFModels
{
    public partial class Request
    {
        public int RequestId { get; set; }
        public int RequestTypeId { get; set; }
        public string RequestTitle { get; set; }
        public string Description { get; set; }
        public DateTime RequestDate { get; set; }
        public DateTime? RequestModifiedDate { get; set; }
        public string RequestorName { get; set; }
        public int PropertyId { get; set; }
        public string RepresentativeName { get; set; }
        public int StatusId { get; set; }
        public string Action { get; set; }
        public bool Urgent { get; set; }
        public bool Active { get; set; }

        public virtual Property Property { get; set; }
        public virtual RequestType RequestType { get; set; }
        public virtual Status Status { get; set; }
    }
}
