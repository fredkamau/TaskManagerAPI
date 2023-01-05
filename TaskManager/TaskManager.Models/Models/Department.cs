using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.Data.Models
{
    public class Department
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ID { get; set; }
        [Required(ErrorMessage = "Please specify a Name")]
        public string?Name { get; set; }
        public string? Location { get; set; }
        public string? ManagerName { get; set; }
        public Guid CreatedById { get; set; }
        public Guid ModifiedById { get; set; }
        public DateTime DateModified { get; set; } = DateTime.UtcNow;
        public string? Notes { get; set; }
        public Boolean Active { get; set; }
    }
}
