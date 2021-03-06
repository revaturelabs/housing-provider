﻿using System;
using System.Collections.Generic;

namespace HousingProvider.Data.Library.Models
{
    public partial class Status
    {
        public Status()
        {
            Request = new HashSet<Request>();
        }

        public int StatusId { get; set; }
        public string StatusDescription { get; set; }
        public bool Active { get; set; }

        public virtual ICollection<Request> Request { get; set; }
    }
}
