namespace banque.Classes
{
    public class Epargne : Compte
    {
        public Epargne(string Numero, Personne Titulaire, DateTime DDR) : base(Numero, Titulaire)
        {
            this.DateDernierRetrait = DDR;
        }
        public DateTime DateDernierRetrait { get; private set; }
        protected override double CalculInteret()
        {
            return _Solde*0.045;
        }
    }
}
