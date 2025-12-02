using System.ComponentModel.DataAnnotations;

namespace fortifyTask.Models
{
    public class TaskModel
    {
        public int id { get; set; }
        [Required]
        public string? TaskName { get; set; }
        [Required]
        public DateTime TaskDate { get; set; }
    }
}
