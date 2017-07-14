using System;
using System.Collections.Generic;

namespace HousingProvider.Data.Service.Models
{
    public partial class Address
    {
        public Address()
        {
            Complex = new HashSet<Complex>();
            Property = new HashSet<Property>();
            Provider = new HashSet<Provider>();
        }

        public int AddressId { get; set; }
        public string Street1 { get; set; }
        public string Street2 { get; set; }
        public int? ApartmentNum { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public bool Active { get; set; }

        public virtual ICollection<Complex> Complex { get; set; }
        public virtual ICollection<Property> Property { get; set; }
        public virtual ICollection<Provider> Provider { get; set; }
    }
}
