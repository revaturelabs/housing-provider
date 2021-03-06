﻿using System;
using System.Collections.Generic;

namespace HousingProvider.Data.Library.Models
{
    public partial class Person
    {
        public int PersonId { get; set; }
        public int? ProviderId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ContactId { get; set; }
        public bool Active { get; set; }
        public Guid Guid { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual Contact Contact { get; set; }
        public virtual Provider Provider { get; set; }
    }
}
