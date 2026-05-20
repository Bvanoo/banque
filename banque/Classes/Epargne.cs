namespace banque.Classes
{
    public class Epargne : Compte
    {
        public Epargne(string Numero, Personne Titulaire):base(Numero, Titulaire)
        {

        }
        public Epargne(string Numero, Personne Titulaire, double Solde):base(Numero, Titulaire, Solde)
        {

        }

        public DateTime DateDernierRetrait { get; private set; }
        protected override double CalculInteret()
        {
            return _Solde*0.045;
        }
    }
}
