using POO.classes;

Client ingenio = new Client("INGENIO", 1);

CompteCourant cpt = new CompteCourant(ingenio, "$", 100000000000);

Console.WriteLine(cpt.Decrire());
Console.ReadLine();