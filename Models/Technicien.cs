namespace SavManagementApp.Models
{
    public class Technicien
    {
        public int Id { get; set; }
        public string Nom { get; set; } // Nom du technicien
        public string Specialite { get; set; } // Spécialité du technicien (par exemple, plomberie, électricité...)
        public string Telephone { get; set; } // Numéro de téléphone du technicien

        // Liste des interventions assignées
        public List<Intervention> Interventions { get; set; }
    }
}
