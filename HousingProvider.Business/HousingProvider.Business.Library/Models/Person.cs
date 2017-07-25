using System;
using System.Collections.Generic;
using System.Text;

namespace HousingProvider.Business.Library.Models
{
    public class Person : IPerson
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public Guid Guid { get; set; }
        public DateTime ModifiedDate { get; set; }

        public override bool Equals(object obj)
        {
            if(obj != null && obj.GetType() == GetType())
            {
                var newPerson = obj as Person;
                return newPerson.FirstName.ToLower().Equals(FirstName.ToLower()) &&
                   newPerson.LastName.ToLower().Equals(LastName.ToLower());
            }
            return false;
        }

        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }

        public override int GetHashCode()
        {
            return FirstName.GetHashCode() + LastName.GetHashCode();
        }

        public override string ToString()
        {
            return string.Format("{0} {1}\n{2}\n{3}",
               FirstName,LastName,EmailAddress,PhoneNumber);
        }
    }
}
