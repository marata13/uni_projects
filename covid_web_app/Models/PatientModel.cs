using System.ComponentModel.DataAnnotations;


namespace covid_web_app.Models
{
    public class PatientModel
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [RegularExpression(@"^([0-9]{10})$", ErrorMessage = "Invalid Phone Number.")]
        public string Phone { get; set; }

        [Required]
        [RegularExpression(@"male|female|other", ErrorMessage = "Please enter 'male' , 'female' or 'other'.")]
        public string Gender { get; set; }

        [Required]
        [Range(1, 125, ErrorMessage = "You have entered an invalid age.")]
        public int Age { get; set; }

        public string UnderlyingDiseases { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public DateTime VaccinationDate { get; set; }

        public int? id { get; set; }
    }
}
