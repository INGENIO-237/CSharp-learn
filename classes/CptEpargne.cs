using POO.classes;

class CompteEpargne : CompteBancaire
{
    public double Taux{get;set;}
    public CompteEpargne(Client clt, string devise, double solde = 0, double taux = 0.25) : base(clt, devise, solde)
    {
        Taux = taux;
    }

    public double CalculerInteret() => Solde * Taux;

    public override void Debiter(int somme)
    {
        if(Solde - somme >= Solde / 2){
            Solde -= somme;
        }
    }
}