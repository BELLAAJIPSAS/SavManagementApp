namespace SavManagementApp.Models
{
    public class Article
    {
        public int Id { get; set; }
        public string Nom { get; set; } // Nom de l'article (par exemple, chauffe-eau, chaudière...)
        public string Description { get; set; } // Description de l'article
        public bool SousGarantie { get; set; } // Si l'article est sous garantie
        public decimal Prix { get; set; } // Prix de l'article

        // Liste des réclamations associées
        public List<Reclamation> Reclamations { get; set; }

        // Liste des interventions associées
        public List<Intervention> Interventions { get; set; }
    }
}
