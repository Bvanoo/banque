namespace banque.Classes
{
    public class Courant : Compte
    {
		private double _LigneDeCredit;

		public static double operator +(double SommeCompte, Courant c)
		{
			return SommeCompte + (c._Solde > 0 ? c._Solde : 0);
		}
        public double LigneDeCredit
		{
			get { return _LigneDeCredit; }
			set { if(value >= 0) {  _LigneDeCredit = value; }; }
		}
	}
}
