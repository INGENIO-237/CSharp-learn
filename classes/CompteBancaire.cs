using System;

namespace POO.classes;

abstract class CompteBancaire{
    public string Devise{get;set;}
    public double Solde{get;set;}

    public Client Titulaire{get;set;}

    public CompteBancaire(Client clt, string devise, double solde = 0){
        Devise = devise;
        Solde = solde;
        Titulaire = clt;
        clt.Comptes.Add(this);
    }

    public void Crediter(int somme){
        Solde += somme;
    }

    public abstract void Debiter(int somme);

    public virtual string Decrire(){
        return $"Compte de {Titulaire.Nom} {Titulaire.Prenom} possedant {Solde}{Devise}";
    }
}