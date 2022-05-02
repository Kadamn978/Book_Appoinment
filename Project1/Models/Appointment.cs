using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Project1.Models
{
    [Table("TblAppoinment")]
    public class Appoinment
    {
        [Key]
        [ScaffoldColumn(false)]
        public int AppId { get; set; }

        [Required(ErrorMessage = " Enter Your First Name")]
        [StringLength(40)]
        [Display(Name = "Enter Your First Name")]
        public string FName { get; set; }

        [Required(ErrorMessage = " Enter Your Last Name")]
        [StringLength(40)]
        [Display(Name = "Enter Your Last Name")]
        public string LName { get; set; }

        [Required(ErrorMessage = " Enter 10 Digit Mobile No.")]
        [StringLength(10)]
        [Display(Name = "Enter Your Contact No.")]
        public string ContactNo { get; set; }

        [Required(ErrorMessage = " Enter Your E-Mail")]
        [StringLength(40)]
        [Display(Name = "Enter Your E-Mail")]
        [DataType(DataType.EmailAddress)]
        public string EMail { get; set; }

        [Display(Name = "Select Appoinment Date")]
        public string AppDate { get; set; }

        [Display(Name = "Select Appoinment Time")]
        public string AppTime { get; set; }

        [Required(ErrorMessage = " Enter Specialist / Doctor")]
        [StringLength(40)]
        [Display(Name = "Enter Specialist / Doctor")]
        public string Specialist { get; set; }
    }
}
