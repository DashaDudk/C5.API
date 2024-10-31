using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitnessSystem.Models
{
    public class Gym
    {
        public int GymID { get; set; }

        [Required(ErrorMessage = "Gym name field is required.")]
        public string Name { get; set; } = null!;

        [Required(ErrorMessage = "Location field is required.")]
        public string Location { get; set; } = null!;

        [Required(ErrorMessage = "Longitude is required.")]
        public double Longitude { get; set; }

        [Required(ErrorMessage = "Latitude is required.")]
        public double Latitude { get; set; }

        [NotMapped]
        public ICollection<Trainer> Trainers { get; set; } = new List<Trainer>();
    }
}