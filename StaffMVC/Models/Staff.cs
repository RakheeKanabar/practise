using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StaffMVC.Models
{
    public class Staff
    {
        public virtual int StaffId { get; set; }


        [Required(ErrorMessage = "A staff Name is required")]
        [StringLength(30)]
        public virtual string Name { get; set; }

        [Required(ErrorMessage = "A email is required")]
        [StringLength(150)]
        public virtual string Email { get; set; }


        [Required(ErrorMessage = "A address is required")]
        [StringLength(100)]
        public virtual string Address { get; set; }

        [Required(ErrorMessage = "A Department is required")]
        [StringLength(150)]
        [DisplayName("Department")]
        public virtual string Department { get; set; }

        [DisplayName("Home Tel")]
        public virtual string HomeTel { get; set; }

        [DisplayName("Mobile Tel")]
        public virtual string MobileTel { get; set; }


    }
}