using System;
using System.Collections.Generic;
using System.Text;

namespace HousingProvider.Business.Library.Models
{
    /// <summary>
    /// This class represent a Property that is used to house Revature
    /// tenants. It facilitate tenants submitting request to fix a
    /// problem that is being experienced within the property that
    /// they reside in.
    /// </summary>
    public class Property : IProperty
    {
        public Address Address { get; set; }
        public int Bathrooms { get; set; }
        public int Bedrooms { get; set; }
        private List<Request> _Requests;
        public List<Request> Requests
        {
            get
            {
                return _Requests;
            }
        }
        
        public Property()
        {
            _Requests = new List<Request>();
        }
        
        /// <summary>
        /// Enable a user to add a request to this property.
        /// The method verify that the request is valid and that
        /// an OPEN request for the same "request" is not active.
        /// </summary>
        /// <param name="newRequest">The request to add</param>
        /// <returns>True if request was added to property, false otherwise</returns>
        public bool AddRequest(Request newRequest)
        {
            if (newRequest != null && !RequestExist(newRequest))
            {
               _Requests.Add(newRequest);
            }
            return false;
        }

        /// <summary>
        /// Compares two Properties for equality using the address of
        /// the properties.
        /// </summary>
        /// <param name="obj">
        /// The Property that this property is being compared
        /// </param>
        /// <returns>
        /// True if the address of both properties are the same,
        /// false otherwise
        /// </returns>
        public override bool Equals(Object obj)
        {
            if (obj != null && obj.GetType() == GetType())
            {
               var newProperty = obj as Property;
               return newProperty.Address.Equals(Address);
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Address.GetHashCode();
        }

        /// <summary>
        /// Return only the open Requests that exist
        /// on this Property. Open request include
        /// Pending and In-Work requests
        /// </summary>
        /// <returns>A List of Pending and In-work requests</returns>
        public List<Request> GetOpenRequests()
        {
            var oRequests = new List<Request>();
            foreach (var r in _Requests)
            {
               if (r.Status != StatusEnum.COMPLETED)
               {
                  oRequests.Add(r);
               }
            }
            return oRequests;
         }

        private bool RequestExist(Request request)
        {
            return _Requests.Contains(request);
        }

        public override string ToString()
        {
            return string.Format("{0} Bedroom{1}, {2} Bathroom{3}\n{4}",
               Bedrooms, Bedrooms > 1 ? "s" : "", Bathrooms, Bathrooms > 1 ? "s" : "", Address);
        }
    }
}
