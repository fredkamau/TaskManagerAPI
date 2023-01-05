using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.Data.Models
{
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ID { get; set; }
        [Required(ErrorMessage = "Please specify First Name")]
        public string? FirstName { get; set; }
        [Required(ErrorMessage = "Please specify Last Name")]
        public string? LaststName { get; set; }
        public string? Title { get; set; }
        public DateTime DOB { get; set; }
        public Decimal MonthlySalary { get; set; }
        [ForeignKey("DepartmentID")]
        public virtual Department? Departments { get; set; }
        public Guid DepartmentID { get; set; }
        public DateTime JoinDate { get; set; }
        public Guid CreatedById { get; set; }
        public Guid ModifiedById { get; set; }
        public DateTime DateModified { get; set; } = DateTime.UtcNow;
        public string? Notes { get; set; }
        public Boolean Active { get; set; }
    }
}
