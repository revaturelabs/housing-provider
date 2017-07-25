using System;
using System.Collections.Generic;
using System.Text;

namespace HousingProvider.Business.Library.Models
{
   /// <summary>
   /// Extends the Request class by adding an Address field that 
   /// represent the Property class address. All MaintenanceRequest
   /// pertain to an existing Property which must have an Address
   /// </summary>
   public class MaintenanceRequest : Request
   {
      public Address PropertyAddress { get; set; }
      public Guid Guid { get; set; }
      public DateTime ModifiedDate { get; set; }

        /// <summary>
        /// Compares two Request for equality using the address for which
        /// the request is logged and the description of the request.
        /// </summary>
        /// <param name="obj">
        /// The request that this request is being compared
        /// </param>
        /// <returns>
        /// True if the address and the description of both request are the same,
        /// false otherwise
        /// </returns>
        public override bool Equals(object obj)
      {
         if (obj != null && obj.GetType() == GetType())
         {
            var newRequest = obj as MaintenanceRequest;
            return newRequest.PropertyAddress.Equals(PropertyAddress) &&
               base.Equals(newRequest);
         }
         return false;
      }

      public override int GetHashCode()
      {
         return PropertyAddress.GetHashCode() + base.GetHashCode();
      }

      public override string ToString()
      {
         return string.Format("From: {0}\nTo: {1}\nFor: {2}",
            Initiator, Provider, Description);
      }
   }
}
