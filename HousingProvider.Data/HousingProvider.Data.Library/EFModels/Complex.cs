using System;
using System.Collections.Generic;

namespace HousingProvider.Data.Library.EFModels
{
    public partial class Complex
    {
        public Complex()
        {
            Property = new HashSet<Property>();
        }

        public int ComplexId { get; set; }
        public string ComplexName { get; set; }
        public int AddressId { get; set; }
        public int ContactId { get; set; }
        public bool Active { get; set; }

        public virtual ICollection<Property> Property { get; set; }
        public virtual Address Address { get; set; }
        public virtual Contact Contact { get; set; }
    }
}
