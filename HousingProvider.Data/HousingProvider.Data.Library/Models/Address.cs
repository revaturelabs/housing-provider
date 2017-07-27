using System;
using System.Collections.Generic;

namespace HousingProvider.Data.Library.Models
{
    public partial class Address
    {
        public Address()
        {
            Complex = new HashSet<Complex>();
            Property = new HashSet<Property>();
        }

        public int AddressId { get; set; }
        public string Street1 { get; set; }
        public string Street2 { get; set; }
        public int? ApartmentNum { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public bool Active { get; set; }
        public Guid Guid { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual ICollection<Complex> Complex { get; set; }
        public virtual ICollection<Property> Property { get; set; }
    }
}
