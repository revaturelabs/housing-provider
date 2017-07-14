using System;
using System.Collections.Generic;

namespace HousingProvider.Data.Service.Models
{
    public partial class Provider
    {
        public Provider()
        {
            Person = new HashSet<Person>();
            Property = new HashSet<Property>();
        }

        public int ProviderId { get; set; }
        public string ProviderName { get; set; }
        public int ContactId { get; set; }
        public int AddressId { get; set; }
        public bool Active { get; set; }

        public virtual ICollection<Person> Person { get; set; }
        public virtual ICollection<Property> Property { get; set; }
        public virtual Address Address { get; set; }
        public virtual Contact Contact { get; set; }
    }
}
