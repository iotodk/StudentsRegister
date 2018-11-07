using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace StudentsRegister.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string CPR { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }

        [NotMapped]
        public string Test { get; set; }
        [NotMapped]
        public string GetAge
        {
            get
            {
                return "" + (DateTime.Now - BirthDate);
            }
        }
        public GenderType Gender { get; set; }

        public enum GenderType
        {
            Female, Male, Other
        }
    }
}