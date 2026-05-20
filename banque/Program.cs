using banque.Classes;
using System;

Banque Fintro = new Banque();
Fintro.Nom = "Fintro";

Personne p1 = new Personne("fred", "testot", new DateTime(1977, 2, 20));

Courant commun = new Courant("123554478612",p1,15,42) ;

commun.PassageEnNegatifEvent += Fintro.PassageEnNegatifAction;

Console.WriteLine($"La banque de {p1.Prenom} {p1.Nom} est {Fintro.Nom}, son numero de compte est le {commun.Numero} et il a une ligneDeCredit de {commun.LigneDeCredit}");