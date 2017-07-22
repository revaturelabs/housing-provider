using System;
using System.Collections.Generic;
using System.Text;

namespace HousingProvider.Data.Library.Abstracts
{
    public abstract class AUniquelyIdentifiableModel
    {
        public abstract Guid Guid { get; set; }
    }
}
