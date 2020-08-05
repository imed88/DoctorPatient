using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DoctorPatient.ViewModels
{
    public class AppointmentDateGroupViewModel
    {
        [DataType(DataType.Date)]
        public DateTime? AppointmentDate { get; set; }

        public int PatientCount { get; set; }

    }
}