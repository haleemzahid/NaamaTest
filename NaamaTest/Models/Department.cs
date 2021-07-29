using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NaamaTest.Models
{
    public class Department
    {
        public int DepartmentID { get; set; }
       
        [Required]
        public string Name{ get; set; }
        public string Description{ get; set; }
        public List<Teacher> Teachers{ get; set; }
       

    }
}