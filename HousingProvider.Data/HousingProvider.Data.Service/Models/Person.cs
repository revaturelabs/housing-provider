using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HousingProvider.Data.Service.Models
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool Active { get; set; }
        public Contact Contact { get; set; }
        public Provider Provider { get; set; }
        public Guid Guid { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
