using System;
using System.Collections.Generic;

namespace HousingProvider.Data.Library.EFModels
{
    public partial class Contact
    {
        public Contact()
        {
            Complex = new HashSet<Complex>();
            Person = new HashSet<Person>();
        }

        public int ContactId { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public bool Active { get; set; }

        public virtual ICollection<Complex> Complex { get; set; }
        public virtual ICollection<Person> Person { get; set; }
    }
}
