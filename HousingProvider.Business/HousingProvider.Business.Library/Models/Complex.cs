using HousingProvider.Business.Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace HousingProvider.Business.Library.Models
{
    public class Complex : ILibraryModel
    {
        public Guid Guid { get; set; }
        public string ComplexName { get; set; }
        public Address Address { get; set; }
        public Guid AddressGuid { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
