using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Project1.Models
{
    [Table("TblAdminReg")]
    public class Admin
    {
        [Key]
        [ScaffoldColumn(false)]
        public int A_Id { get; set; }

        [Required(ErrorMessage = " Enter Your First Name")]
        [StringLength(40)]
        [Display(Name = "Enter Your First Name")]
        public string A_FName { get; set; }

        [Required(ErrorMessage = " Enter Your Last Name")]
        [StringLength(40)]
        [Display(Name = "Enter Your Last Name")]
        public string A_LName { get; set; }

        [Required(ErrorMessage = " Enter Your E-Mail")]
        [StringLength(40)]
        [Display(Name = "Enter Your E-Mail")]
        [DataType(DataType.EmailAddress)]
        public string A_EMail { get; set; }

        [Required(ErrorMessage = " Enter Your Password ")]
        [MaxLength(20, ErrorMessage = "Max 20 Character Required")]
        [DataType(DataType.Password)]
        [MinLength(6, ErrorMessage = "Min 6 Character Required")]
        [Display(Name = "Enter Your Password")]
        public string A_Password { get; set; }

        [Required(ErrorMessage = " Enter Your Confirm Password ")]
        [MaxLength(20, ErrorMessage = "Max 20 Character Required")]
        [DataType(DataType.Password)]
        [MinLength(6, ErrorMessage = "Min 6 Character Required")]
        [Display(Name = "Enter Your Confirm Password")]
        [Compare("Password", ErrorMessage = "Password did Not Match")]
        public string Confirm_A_Password { get; set; }

    }
}
