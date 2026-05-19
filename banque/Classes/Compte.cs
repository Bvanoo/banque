namespace banque.Classes
{
    public class Compte
    {
        public string Numero { get; set; } = null!;
        private protected double _Solde;
        public Personne Titulaire { get; set; } = null!;

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
