using POO.classes;

class CompteCourant : CompteBancaire
{
    public double DecouvertMax{get;set;}
    public CompteCourant(Client clt, string devise, long solde = 0, double decouvert = 5000) : base(clt, devise, solde)
    {
        DecouvertMax = decouvert;
    }

    public override void Debiter(int somme)
    {
        if(Solde - somme >= DecouvertMax){
            Solde -= somme;
        }
    }
}