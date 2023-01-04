using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TaskManager.Data.Models
{
    public class Project
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ID { get; set; }
        public string? Name { get; set; }
        public string? Code { get; set; }
        public DateTime StartDate { get; set; }
        public Guid CreatedById { get; set; }
        public Guid ModifiedById { get; set; }
        public DateTime DateModified { get; set; } = DateTime.UtcNow;
        public string? Notes { get; set; }
        public Boolean Active { get; set; }
    }
}