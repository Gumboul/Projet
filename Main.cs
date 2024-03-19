public class Projet
{
	public static void Main()
	{
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        
		//Le nom et prénom de votre joueur
		
		Console.Write("Entrez le nom du joueur : ");
        string Joueursnom = Console.ReadLine();
		Console.WriteLine("Entrez le prénom de votre joueur :");
		string Joueurprenom = Console.ReadLine();
		int Nombrevie = 100;
        Joueurs instancej = new Joueurs("lieu", 0, Nombrevie, Joueursnom, Joueurprenom);
        Console.WriteLine("Vous avez choisi comme nom : " + instancej.NomJoueur);
		Console.WriteLine("Vous avez choisi comme prénom : " + instancej.Joueurprenom);
		
		
		//Choix de la classe et Création Arme
		
		Console.WriteLine("Vueillez choisir entre ces 3 classes : Chevalier, Barbare, Archer");
		string Possede = (".");
		string Choix = Console.ReadLine();
		if (Choix == "Barbare") {
				instancej.additem(new Armes(40,"Hache"));
				Possede = ("Hache");
		}
		if (Choix == "Chevalier") {
				instancej.additem(new Armes(20,"epee"));
				Possede = ("Epée");
		}
		if (Choix == "Archer") {
				instancej.additem(new Armes(15,"Arc"));
				Possede = ("Arc");
		}
		

		
		
		
		
		//L'affichage des informations
		
		Console.WriteLine("*********************************************");
		Console.WriteLine("* Voici votre fiche personnage :            ");
		Console.WriteLine("* Votre Nom : " + instancej.NomJoueur);
		Console.WriteLine("* Votre Prénom : " + instancej.Joueurprenom);
		Console.WriteLine("* Vos point de vie sont : " + instancej.Nombrevie);
		Console.WriteLine("* Votre classe est : " + Choix);
		Console.WriteLine("* Votre arme est : " + Possede);
	}
}