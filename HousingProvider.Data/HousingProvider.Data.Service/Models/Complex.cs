using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HousingProvider.Data.Service.Models
{
    public class Complex
    {
        public string ComplexName { get; set; }
        public bool Active { get; set; }
        public Address Address { get; set; }
        public Guid AddressGuid { get; set; }
        public Guid Guid { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
    }
}
