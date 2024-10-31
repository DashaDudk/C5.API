using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FitnessSystem.Models
{
    public class Trainer
    {
        public int TrainerID { get; set; }

        [Required(ErrorMessage = "Trainer name field is required.")]
        public string Name { get; set; } = null!;

        [Required(ErrorMessage = "Specialization field is required.")]
        public string Specialization { get; set; } = null!;

        public string? Certificates { get; set; } 

        [Required(ErrorMessage = "Gym is field required.")] 
        public int GymID { get; set; } 

        [ForeignKey("GymID")]
        public Gym ?Gym { get; set; }
        public ICollection<Client> Clients { get; set; } = new List<Client>();
    }
}