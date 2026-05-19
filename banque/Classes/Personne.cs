namespace banque.Classes
{
    public class Personne
    {
        public Personne(string Nom, string Prenom, DateTime DateNaiss)
        {
            this.Nom = Nom;
            this.Prenom = Prenom;
            this.DateNaiss = DateNaiss;
        }
        public string Nom { get; private set; } = null!;
        public string Prenom { get; private set; } = null!;
        public DateTime DateNaiss { get; private set; }
    }
}
