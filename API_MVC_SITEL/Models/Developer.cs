using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API_MVC_SITEL.Models
{
    public class Developer
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string FirstSurname { get; set; }
        public string SecondSurname { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }

        //public Nullable<string> ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public byte Enabled { get; set; }
    }
}