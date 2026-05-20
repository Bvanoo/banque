using banque.Interface;

namespace banque.Classes
{
    public delegate void PassageEnNegatifDelegate(Compte c);
    public abstract class Compte : IBanker
    {
    public event PassageEnNegatifDelegate? PassageEnNegatifEvent;
        public Compte(string Numero, Personne Titulaire)
        {
            this.Numero = Numero;
            this.Titulaire = Titulaire;
        }

        public Compte(string Numero, Personne Titulaire, double Solde):this(Numero, Titulaire)
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
            try
            {
                if(Solde - montant<= 0)
                {
                    PassageEnNegatifEvent(this);
                    throw new SoldeInsuffisantException("Solde insufisant", "Vous devez disposer de plus d'argent que vous ne souhaitez en retirer");
                }
            }catch(SoldeInsuffisantException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void Depot(double montant)
        {
            try
            {

            if(montant <=0)
            {
                throw new ArgumentOutOfRangeException(nameof(montant), "Vous ne pouvez pas déposer un montant egal ou inférieur a zero");
            }
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public double Solde
        {
            get { return _Solde; }
            private set { _Solde = value; }
        }
    }
    public class SoldeInsuffisantException : Exception
    {
        public string varEx { get; set; }
        public SoldeInsuffisantException(string exc, string message) : base(message)
        {
            this.varEx = exc;
        }
    }
}
