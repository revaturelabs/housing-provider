using System;
using System.Collections.Generic;

namespace HousingProvider.Data.Service.EFModels
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
        public int AddressId { get; set; }
        public bool Active { get; set; }
        public Guid Guid { get; set; }

        public virtual ICollection<Person> Person { get; set; }
        public virtual ICollection<Property> Property { get; set; }
    }
}
