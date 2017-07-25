using HousingProvider.Business.Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace HousingProvider.Business.Library.Models
{
   /// <summary>
   /// Represent a request for accommodation or supplies
   /// </summary>
   public class Request : ILibraryModel
   {
      public bool Urgent { get; set; }
      public string Initiator { get; set; }
      public string Provider { get; set; }
      public string Title { get; set; }
      public string Description { get; set; }
      public string CorrectiveAction { get; set; }
      public DateTime DateSubmitted { get; set; }
      public DateTime DateModified { get; set; }
      public StatusEnum Status { get; set; }
      public Guid Guid { get; set; }

        /// <summary>
        /// Compares two Request for equality using the descriptions and
        /// statuses of each request. 
        /// </summary>
        /// <param name="obj">
        /// The request that this request is being compared
        /// </param>
        /// <returns>
        /// True if the description of both request are the same and there statuses are either pending or in-work,
        /// false otherwise
        /// </returns>
        public override bool Equals(object obj)
      {
         if (obj != null && obj.GetType() == GetType())
         {
            var newRequest = obj as Request;
            return newRequest.Description.ToLower().Equals(Description.ToLower()) &&
               ((newRequest.Status == StatusEnum.PENDING || newRequest.Status == StatusEnum.INWORK) &&
               (Status == StatusEnum.PENDING || Status == StatusEnum.INWORK));
         }
         return false;
      }

      /// <summary>
      /// Generage a unique number for this object
      /// </summary>
      /// <returns>
      /// A number that represent this class
      /// </returns>
      public override int GetHashCode()
      {
         return Description.GetHashCode() + DateSubmitted.GetHashCode();
      }

      /// <summary>
      /// Generate a string representation of this class
      /// </summary>
      /// <returns>
      /// String representation of this class instance
      /// </returns>
      public override string ToString()
      {
         return string.Format("From: {0}\nTo: {1}\nOn: {2} Description: {3}",
            Initiator, Provider, DateSubmitted, Description);
      }
   }
}
