namespace MVC.net.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Employee")]
    public partial class Employee
    {
        public int EmployeeID { get; set; }

        [Required(ErrorMessage ="This feild is required")]
        [StringLength(50)]
        public string Name { get; set; }

        [Required(ErrorMessage = "This feild is required")]
        [StringLength(50)]
        public string Position { get; set; }

        [StringLength(50)]
        public string Office { get; set; }

        public int? Age { get; set; }

        public int? Salary { get; set; }
    }
}
