using System;
using System.Collections.Generic;

namespace HousingProvider.Data.Library.Models
{
    public partial class Property
    {
        public Property()
        {
            Request = new HashSet<Request>();
        }

        public int PropertyId { get; set; }
        public int NumberofRooms { get; set; }
        public int NumberofBaths { get; set; }
        public int ProviderId { get; set; }
        public int AddressId { get; set; }
        public int ComplexId { get; set; }
        public bool Active { get; set; }
        public Guid Guid { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual ICollection<Request> Request { get; set; }
        public virtual Address Address { get; set; }
        public virtual Complex Complex { get; set; }
        public virtual Provider Provider { get; set; }
    }
}
