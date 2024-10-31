namespace FitnessSystem.Models
{
    public class Membership
    {
        public int MembershipID { get; set; }
        public string Type { get; set; } = null!;
        public decimal Price { get; set; }
        public int ClientID { get; set; } 
        public virtual Client? Client { get; set; }
    }
}
