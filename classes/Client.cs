using System;
using POO.classes;

class Client{
    public string Nom{get;set;}
    public string Prenom{get;set;}
    public long Numero{get;set;}
    public List<CompteBancaire> Comptes;

    public Client(string nom, int numero, string prenom = ""){
        Nom = nom;
        Prenom = prenom;
        Numero = numero;
        Comptes = new List<CompteBancaire>();
    }
}
