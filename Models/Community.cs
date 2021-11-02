using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Lab4.Models
{
    public class Community
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required(ErrorMessage = "ID is required")]
        [DisplayName("Registration Number")]
        public string Id { get; set; }

        [Required(ErrorMessage = "Title is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Maximum 50 characters, Minimum 3 characters.")]
        public string Title { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName = "money")]
        public decimal Budget { get; set; }

        //proper navigational properties for this model
        public ICollection<CommunityMembership> Membership { get; set; }

    }
}
