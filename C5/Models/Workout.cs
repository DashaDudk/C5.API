namespace FitnessSystem.Models
{
    public class Workout
    {
        public int WorkoutID { get; set; }
        public string WorkoutName { get; set; } = null!;
        public DateTime Date { get; set; }
        public string Plan { get; set; } = null!;
        public int ClientID { get; set; } 
        public virtual Client? Client { get; set; } 
    }
}
