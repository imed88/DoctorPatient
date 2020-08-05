using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DoctorPatient.Models
{
    public class AdministrationModel
    {
        [Required]
        public int ID { get; set; }

        [Required]
        public String Name { get; set; }

        [Required]
        public string Value { get; set; }
    }
}