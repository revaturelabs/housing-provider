using System;
using System.Collections.Generic;

namespace HousingProvider.Data.Service.Models
{
    public partial class Role
    {
        public Role()
        {
            Person = new HashSet<Person>();
        }

        public int RoleId { get; set; }
        public string RoleDescription { get; set; }
        public bool Active { get; set; }

        public virtual ICollection<Person> Person { get; set; }
    }
}
