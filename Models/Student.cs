using System.ComponentModel.DataAnnotations;
namespace ModelDemo.Models

{
    public class Student:IValidatableObject
    {
        [Required(ErrorMessage = "Stud id Required")]
        [Display(Name = "Stud RollNo")]
        public int StudetRollNo { get; set; }
        [Required(ErrorMessage = "Student Name Is Required")]
        [Display(Name = "Student Name")]
        [MaxLength(40, ErrorMessage = "Name Must have lessthan 40 char")]
        [MinLength(2)]

        public string? StudentName { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }
       
        [Required]
        [Range(13, 30)]
        public int Age { get; set; }
        [Display(Name = "Date Of Birth")]
        [DataType(DataType.Date)]
        public DateTime Dob { get; set; }
        [Required]
        public String SpecialSubject { get; set; }

        [Required]
        public double Percentage { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var PName = new[] { "Dob" };
            if (Dob > DateTime.Now)
            {
                yield return new ValidationResult("Date of birth can not be in future", PName);
            }
            if (Dob < DateTime.Now.AddYears(-100))
            {
                yield return new ValidationResult("Date of birth can not be in too past", PName);
            }

        }
    }
}

