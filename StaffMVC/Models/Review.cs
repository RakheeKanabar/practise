using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StaffMVC.Models
{
    public class Review
    {
        public virtual int ReviewId { get; set; }
        [Required(ErrorMessage = "Rating is required, enter a number between 1-10")]

        [Range(1, 10, ErrorMessage = "Value for {0} must be between {1} and {2}.")]
        public virtual int Rate { get; set; }

        [Required(ErrorMessage = "A Staff Description is required")]
        [StringLength(8000)]
        public virtual string Description { get; set; }

        public virtual int StaffId { get; set; }
         public virtual Staff staff { get; set; }
    }
}