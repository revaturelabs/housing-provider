using HousingProvider.Business.Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace HousingProvider.Business.Library.Models
{
    public class Contact: ILibraryModel
    {
        public string Email { get; set; }

        public string Phone { get; set; }
    }
}
