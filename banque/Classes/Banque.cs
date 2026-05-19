namespace banque.Classes
{
    public class Banque
    {
        public string Nom { get; set; } = null!;

        public Dictionary<string, Compte> compte { get; set; } = new Dictionary<string, Compte>();
        public double AvoirDesComptes(Personne titulaire)
        {
            double totAvoir = 0;
            foreach(KeyValuePair<string, Compte>  compte in compte)
            {
                if(compte.Value.Titulaire == titulaire)
                {
                    totAvoir += compte.Value.Solde;
                }
            }
            return totAvoir;
        }

        public Compte this[string Numero]
        {
            get {   Compte c;
                    compte.TryGetValue(Numero, out c);
                    return c; 
                }
            set { compte[Numero] = value; }
        }


        public void Ajouter()
        {

        }
        public void Supprimer()
        {

        }
    }
}
