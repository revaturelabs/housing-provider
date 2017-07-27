using HousingProvider.Business.Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace HousingProvider.Business.Library.Models
{
    public class Address : ILibraryModel
    {
        public string Street1 { get; set; }
        public string Street2 { get; set; }
        public int ApartmentNum { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public Guid Guid { get; set; }
        public DateTime ModifiedDate { get; set; }
   }
}
