using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Csharp_tuto.Day3.TP5
{

    public abstract class Compte
    {
        public string Proprietaire { get; set; }
        protected List<Operation> listOperation;

        public virtual decimal Solde
            {
        get
        {
                decimal total = 0;
                // todo
                return total;
        }
            }

        public void Crediter (decimal montant)
        {
            Operation op = new Operation
            {
                Montant = montant,
                TypeDeMouvement = Mouvement.Credit
            };
            listOperation.Add(op);

        }

        public void Crediter(decimal montant, Compte compte)
        {
            this.Crediter(montant);
            this.Debiter(montant);

        }

        public void Debiter(decimal montant)
        {
            Operation op = new Operation
            {
                Montant = montant,
                TypeDeMouvement = Mouvement.Debit
            };
            listOperation.Add(op);
        }

        public void Debiter(decimal montant, Compte compte)
        {
            this.Debiter(montant);
            this.Crediter(montant);
        }
    }

    enum Mouvement
    {
        Credit,
        Debit
    }
}