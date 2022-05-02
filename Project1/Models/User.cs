using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace Project1.Models
{

    [Table("TblUserReg")]
    public class User
    {
        [Key]
        [ScaffoldColumn(false)]
        public int U_Id { get; set; }

        [Required(ErrorMessage = " Enter Your First Name")]
        [StringLength(40)]
        [Display(Name = "Enter Your First Name")]
        public string U_FName { get; set; }

        [Required(ErrorMessage = " Enter Your Last Name")]
        [StringLength(40)]
        [Display(Name = "Enter Your Last Name")]
        public string U_LName { get; set; }



        [Required(ErrorMessage = " Enter 10 Digit Mobile No.")]
        [StringLength(10)]
        [Display(Name = "Enter Your Contact No.")]
        public string U_ContactNo { get; set; }

        [Required(ErrorMessage = " Enter Your E-Mail")]
        [StringLength(40)]
        [Display(Name = "Enter Your E-Mail")]
        [DataType(DataType.EmailAddress)]
        public string UEMail { get; set; }

        [Required(ErrorMessage = " Enter Your Address")]
        [StringLength(200)]
        [Display(Name = "Enter Your Address")]
        public string U_Address { get; set; }

        [Required(ErrorMessage = " Enter Your Password ")]
        [MaxLength(20, ErrorMessage = "Max 20 Character Required")]
        [DataType(DataType.Password)]
        [MinLength(6, ErrorMessage = "Min 6 Character Required")]
        [Display(Name = "Enter Your Password")]
        public string U_Password { get; set; }

        [Required(ErrorMessage = " Enter Your Confirm Password ")]
        [MaxLength(20, ErrorMessage = "Max 20 Character Required")]
        [DataType(DataType.Password)]
        [MinLength(6, ErrorMessage = "Min 6 Character Required")]
        [Display(Name = "Enter Your Confirm Password")]
        [Compare("Password", ErrorMessage = "Password did Not Match")]
        public string Confirm_U_Password { get; set; }

    }
}
