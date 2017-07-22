using System;
using System.Collections.Generic;
using System.Text;

namespace HousingProvider.Data.Library.Interfaces
{
    public interface UniquelyIdentifiable
    {
        Guid Guid { get; set; }
    }
}
