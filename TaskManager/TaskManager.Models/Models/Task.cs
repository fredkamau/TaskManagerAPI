using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.Data.Models
{
    public class Task
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ID { get; set; }
        public string? Description { get; set; }
        [ForeignKey("ProjectID")]
        public virtual Project? Projects { get; set; }
        public Guid ProjectID { get; set; }
        [ForeignKey("EmployeeID")]
        public virtual Employee? Employees { get; set; }
        public Guid EmployeeID { get; set; }
        public string? Status { get; set; }
        public string? PriorityLevel { get; set; }
        public DateTime DueDate { get; set; }
        public Guid CreatedById { get; set; }
        public Guid ModifiedById { get; set; }
        public DateTime DateModified { get; set; } = DateTime.UtcNow;
        public string? Notes { get; set; }
        public Boolean Active { get; set; }
    }
}
