using System;
using System.Collections.Generic;
using System.Text;

namespace HousingProvider.Business.Library.Models
{
   /// <summary>
   /// Manages the business logic for the housing provider service.
   /// This class apply the rules that determine whether a requested 
   /// service is valid and respond accordingly. If the requested service
   /// is not valid, a null pointer is returned
   /// </summary>
   public class LibraryManager
   {
      /// <summary>
      /// Add all the request that has been submitted against
      /// this property as a list
      /// </summary>
      /// <param name="Properties"></param>
      /// <param name="Requests"></param>
      /// <returns></returns>
      public List<Property> AssemblyObject(List<Property> Properties, List<Request> Requests)
      {
         foreach (var property in Properties)
         {
            foreach (var request in Requests)
            {
               if (property.Address.Equals(((MaintenanceRequest)request).PropertyAddress))
               {
                  property.AddRequest(request);
               }
            }
         }
         return Properties;
      }

      public Request ValidateObject(List<Request> Objects, Request newObject)
      {
         if (newObject != null)
         {
            if (newObject is MaintenanceRequest)
            {
               var mrequest = newObject as MaintenanceRequest;
               if (!IsAddressValid(mrequest.PropertyAddress))
               {
                  return null;
               };
            }

            if (IsRequestValid(newObject))
            {
               newObject.DateSubmitted = DateTime.Now;
               newObject.DateModified = DateTime.Now;
               newObject.Status = StatusEnum.PENDING;

               // O(n)
               return Objects.Contains(newObject) ? newObject : null;
            }
         }
         return null;
      }

      public Property ValidateObject(List<Property> Properties, Property newProperty)
      {
         if (newProperty != null)
         {
            if (IsPropertyValid(newProperty))
            {
               // O(n) --
               return !Properties.Contains(newProperty) ? newProperty : null;
            }
         }
         return null;
      }

      private bool IsAddressValid(Address address)
      {
         return address.Street1.Length > 2 &&
            address.Street2.Length > 0 &&
            address.City.Length > 0 &&
            address.State.Length == 2 &&
            address.ZipCode.Length >= 5;
      }

      private bool IsPropertyValid(Property property)
      {
         return property.Bedrooms > 0 &&
            property.Bathrooms > 0 &&
            IsAddressValid(property.Address);
      }

      private bool IsRequestValid(Request request)
      {
         return request.Initiator.Length > 0 &&
            request.Provider.Length > 0 &&
            request.Title.Length > 0 &&
            request.Description.Length > 9;
      }
   }
}
