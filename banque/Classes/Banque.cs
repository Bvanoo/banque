using System.Collections;

namespace banque.Classes
{
    public class Banque
    {
        public string Nom { get; set; } = null!;


        public Dictionary<string, Courant> compte { get; set; } = new Dictionary<string, Courant>();
        public double AvoirDesComptes(Personne titulaire)
        {
            double totAvoir = 0;
            foreach(KeyValuePair<string, Courant>  compte in compte)
            {
                if(compte.Value.Titulaire == titulaire)
                {
                    totAvoir += compte.Value;
                }
            }
            return totAvoir;
        }

        public Courant this[string Numero]
        {
            get {   Courant c;
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
