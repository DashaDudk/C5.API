using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitnessSystem.Models
{
    public class Client
    {
        public int ClientID { get; set; }

        [Required(ErrorMessage = "Client name field is required.")]
        public string Name { get; set; } = null!;

        [Required(ErrorMessage = "FitnessGoal field is required.")]
        public string FitnessGoal { get; set; } = null!;

        [Required(ErrorMessage = "Progress field is required.")]
        public string Progress { get; set; } = null!;

        [Required(ErrorMessage = "Trainer field is required.")]
        public int TrainerID { get; set; }
        public virtual Trainer? Trainer { get; set; }

        [NotMapped]
        public ICollection<Workout> Workouts { get; set; } = new List<Workout>();
        [NotMapped]
        public ICollection<Membership> Memberships { get; set; } = new List<Membership>();
    }
}
