using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TestingProject.Models
{
    public class Businessperson
    {
        [Key]
        public int BusinesspersonID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public Dictionary<string, Array> Availability { get; set; }
    }
}