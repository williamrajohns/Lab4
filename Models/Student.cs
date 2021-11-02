using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Lab4.Models
{
    public class Student
    {
        public int Id { get; set; }

        [StringLength(50, ErrorMessage = "Last Name cannot exceed 50 characters.")]
        [Required(ErrorMessage = "Last Name is required")]
        [DisplayName("Last Name")]
        public string LastName { get; set; }

        [StringLength(50, ErrorMessage = "First Name cannot exceed 50 characters.")]
        [Required(ErrorMessage = "First Name is required")]
        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Enrollment Date")]
        public DateTime EnrollmentDate { get; set; }

        public string FullName
        {
            get
            {
                return LastName + ", " + FirstName;
            }
            // set; //not sure if needed
        }

        //proper navigational properties for this model
        public ICollection<CommunityMembership> Membership { get; set; }
    }
}
