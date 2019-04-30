namespace Csharp_tuto.Day3.TP5
{
    public class Operation
    {
        private Mouvement _typeDeMouvement;

        public decimal Montant { get; set; }
        public Mouvement TypeDeMouvement { get => _typeDeMouvement; set => _typeDeMouvement = value; }
    }
}