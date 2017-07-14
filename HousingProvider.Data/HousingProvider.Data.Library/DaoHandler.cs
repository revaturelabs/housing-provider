using HousingProvider.Data.Library.DAOModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace HousingProvider.Data.Library
{
    public class DaoHandler
    {
        public PropertyDAO PropertyDao { get; set; }
        public PersonDAO PersonDao { get; set; }
        public ProviderDAO ProviderDao { get; set; }
        public AddressDAO AddressDao { get; set; }
        public RequestDAO RequestDao { get; set; }
    }
}
