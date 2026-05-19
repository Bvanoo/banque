using banque.Classes;

namespace banque.Interface
{
    interface IBanker : ICustomer
    {
        public double AppliquerInteret();
        public Personne Titulaire { get; }
        public string Numero { get; }
    }
}
