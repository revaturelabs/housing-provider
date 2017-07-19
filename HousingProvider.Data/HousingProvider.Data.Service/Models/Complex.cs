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
        public Contact Contact { get; set; }
    }
}
