namespace banque.Interface
{
    interface ICustomer
    {
        public double Solde { get; }
        public void Depot(double Montant);
        public void Retrait(double Montant);
    }
}
