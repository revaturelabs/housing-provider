using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HousingProvider.Data.Service.Models
{
    public class Property
    {
        public int NumberOfRooms { get; set; }
        public int NumberOfBaths { get; set; }
        public bool Active { get; set; }
    }
}
