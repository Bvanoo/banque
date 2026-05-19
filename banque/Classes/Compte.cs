using banque.Interface;

namespace banque.Classes
{
    public abstract class Compte : IBanker
    {

        public Compte(string Numero, Personne Titulaire)
        {
            this.Numero = Numero;
            this.Titulaire = Titulaire;
        }
        public Compte(string Numero, Personne Titulaire, double Solde) : this(Numero, Titulaire)
        {
            this.Solde = Solde;
        }


        public string Numero { get; private set; } = null!;
        private protected double _Solde;
        public Personne Titulaire { get; private set; } = null!;
        protected abstract double CalculInteret();

        public double AppliquerInteret()
        {
            return _Solde + CalculInteret();
        }

        public void Retrait(double montant)
        {

        }

        public void Depot(double montant)
        {

        }

        public double Solde
        {
            get { return _Solde; }
            private set { _Solde = value; }
        }
    }
}
