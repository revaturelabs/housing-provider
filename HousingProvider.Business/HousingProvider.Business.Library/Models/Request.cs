using System;
using System.Collections.Generic;
using System.Text;

namespace HousingProvider.Business.Library.Models
{
    public class Request
    {
        public int Status { get; set; }
        public bool Urgent { get; set; }
        public string PropertyAddress { get; set; }
        public string Initiator { get; set; }
        public string Provider { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string CorrectiveAction { get; set; }
        public DateTime DateSubmitted { get; set; }
        public DateTime DateModified { get; set; }
    }
}
