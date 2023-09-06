using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GenericClassesTo_Perform_CRUDOperations.Models
{
    [Table("Student")]
    public class Student
    {
        [Key]

        public int Id { get; set; }
        public string Name { get; set; }    
        public int Class { get; set; }
    }
}