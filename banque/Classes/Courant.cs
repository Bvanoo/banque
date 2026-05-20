namespace banque.Classes
{
    public class Courant : Compte
    {
		public Courant(string Numero, Personne Titulaire, double LDC):base(Numero, Titulaire) 
		{
			this.LigneDeCredit = LDC;
		}
		public Courant(string Numero, Personne Titulaire,double Solde, double LDC):base(Numero, Titulaire, Solde) 
		{
			this.LigneDeCredit = LDC;
		}



        private double _LigneDeCredit;
        protected override double CalculInteret()
        {
			if (_Solde >0)
			{
				return _Solde*0.03;
			}
			else
			{
				return _Solde * 0.0975;
			}
        }
        public static double operator +(double SommeCompte, Courant c)
		{
			return SommeCompte + (c._Solde > 0 ? c._Solde : 0);
		}
        public double LigneDeCredit
		{
			get { return _LigneDeCredit; }
			set {
				try
				{
				double v = value <= 0 ? throw new InvalidOperationException("Votre	ligne de crédit est inférieure ou égale a 0") : _LigneDeCredit = value;   
				}catch(Exception ex)
				{
					Console.WriteLine(ex.Message);
				}
				}
		}
	}
}
