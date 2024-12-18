namespace SavManagementApp.Models
{
    public class Reclamation
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public string Statut { get; set; }

        // Relation avec le client
        public int ClientId { get; set; }
        public Client Client { get; set; }
    }
}
