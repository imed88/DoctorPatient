using DoctorPatient.Models;
using DoctorPatient.Validations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DoctorPatient.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        //New fields to extend ApplicationUser class.
        [Required]
        [StringLength(60, MinimumLength = 3)]
        [Display(Name = "Full Name")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [MyBirthDateValidation(ErrorMessage = "You cannot be from the Future!")]

        public DateTime BirthDate { get; set; }

        [Required]
        public Enums.Sex Sex { get; set; }

        public Boolean Blocked { get; set; }

        public virtual List<AppointmentModel> Appointments { get; set; }

        // Return a pre populated instance of ApplicationUser, helps in controller!
        public ApplicationUser GetUser()
        {
            var user = new ApplicationUser()
            {
                UserName = this.UserName,
                Name = this.Name,
                BirthDate = this.BirthDate,
                Sex = this.Sex,
                Appointments = this.Appointments,
                Blocked = this.Blocked,
            };
            return user;
        }
    }

}