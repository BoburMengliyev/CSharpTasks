using ManagementSystemTask.Models.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ManagementSystemTask.Models.Users
{
    public class User
    {
        public int Id { get; set; }
        [Required, MaxLength(200)]
        public string Name { get; set; }
        [Required, MaxLength(200), EmailAddress]
        public string Email { get; set; }
        public DateTime RegistrationDate { get; set; }
        public virtual ICollection<TaskItem> Tasks { get; set; } = 
            new List<TaskItem>();
    }
}
