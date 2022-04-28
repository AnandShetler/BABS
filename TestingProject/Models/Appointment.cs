using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TestingProject.Models
{
    // Model which matches the Appointments collection in Firebase
    public class Appointment
    {
        [Key]
        public int AppointmentID { get; set; }
        [ForeignKey("BusinesspersonID")]
        public Businessperson Businessperson { get; set; }
        [ForeignKey("ClientID")]
        public Client Client { get; set; }
        public DateTime Datetime { get; set; }
        public string Location { get; set; }
    }
}