using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NaamaTest.Models
{
    public class Teacher
    {
        public int TeacherID { get; set; }
        public string Name { get; set; }
        public DateTime DOB{ get; set; }
        public string Address{ get; set; }
        public string PhoneNumber{ get; set; }
       
        [DataType(DataType.EmailAddress)]
        public string Email{ get; set; }
        public Department Department { get; set; }
        public int DepartmentID { get; set; }
        
    }
}