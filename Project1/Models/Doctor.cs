using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Project1.Models
{

    [Table("TblDoctorReg")]
    public class Doctor
    {

        [Key]
        [ScaffoldColumn(false)]
        public int D_Id { get; set; }

        [Required(ErrorMessage = " Enter Your First Name")]
        [StringLength(40)]
        [Display(Name = "Enter Your First Name")]
        public string D_FName { get; set; }

        [Required(ErrorMessage = " Enter Your Last Name")]
        [StringLength(40)]
        [Display(Name = "Enter Your Last Name")]
        public string D_LName { get; set; }


        [Required(ErrorMessage = " Enter 10 Digit Mobile No.")]
        [StringLength(10)]
        [Display(Name = "Enter Your Contact No.")]
        public string D_ContactNo { get; set; }

        [Required(ErrorMessage = " Enter Your E-Mail")]
        [StringLength(40)]
        [Display(Name = "Enter Your E-Mail")]
        [DataType(DataType.EmailAddress)]
        public string D_EMail { get; set; }

        [Required(ErrorMessage = " Enter Your Address")]
        [StringLength(200)]
        [Display(Name = "Enter Your Address")]
        public string D_Address { get; set; }

        [Required(ErrorMessage = " Enter Your Qualiifcation")]
        [StringLength(200)]
        [Display(Name = "Enter Your Qualiifcation")]
        public string D_Qualiifcation { get; set; }

        [Required(ErrorMessage = " Enter Your Specialization")]
        [StringLength(200)]
        [Display(Name = "Enter Your Specialization")]
        public string D_Specialization { get; set; }

        [Required(ErrorMessage = " Enter Your Years Of Experience ")]
        [StringLength(2)]
        [Display(Name = "Enter Your Years Of Experience ")]
        public string D_Experience { get; set; }

        [Required(ErrorMessage = " Enter Your Password ")]
        [MaxLength(20, ErrorMessage = "Max 20 Character Required")]
        [DataType(DataType.Password)]
        [MinLength(6, ErrorMessage = "Min 6 Character Required")]
        [Display(Name = "Enter Your Password")]
        public string D_Password { get; set; }

        [Required(ErrorMessage = " Enter Your Confirm Password ")]
        [MaxLength(20, ErrorMessage = "Max 20 Character Required")]
        [DataType(DataType.Password)]
        [MinLength(6, ErrorMessage = "Min 6 Character Required")]
        [Display(Name = "Enter Your Confirm Password")]
        [Compare("Password", ErrorMessage = "Password did Not Match")]
        public string Confirm_D_Password { get; set; }


    }
}
