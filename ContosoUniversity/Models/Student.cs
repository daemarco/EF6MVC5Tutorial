using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContosoUniversity.Models
{
    public class Student
    {
        /// <summary>
        /// By default EF uses columns named "ID" or "ClassNameID" as default keys
        /// </summary>
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public string EMailAddress { get; set; }

        /// <summary>
        /// This is a navigation property
        /// </summary>
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}