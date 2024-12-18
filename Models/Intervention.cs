namespace SavManagementApp.Models
{
    public class Intervention
    {
        public int Id { get; set; }
        public DateTime DateIntervention { get; set; }
        public decimal CouteIntervention { get; set; } // Coût de l'intervention
        public bool EstGratuit { get; set; } // Si l'intervention est gratuite ou facturée
        public string Description { get; set; }

        // Relation avec Reclamation
        public int ReclamationId { get; set; }
        public Reclamation Reclamation { get; set; }

        // Relation avec Technicien
        public int TechnicienId { get; set; }
        public Technicien Technicien { get; set; }

        // Relation avec Article
        public int ArticleId { get; set; }
        public Article Article { get; set; }
    }
}
