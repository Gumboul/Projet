using System;
using System.Collections.Generic;
					
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
		int Nombrevie = 200;
		int pvGrimgor = 300;
		int degats = 0;
		int degatsGrim = 0;
        Joueurs instancej = new Joueurs("lieu",0, Nombrevie, Joueursnom, Joueurprenom, pvGrimgor);
        Console.WriteLine("Vous avez choisi comme nom : " + instancej.NomJoueur);
		Console.WriteLine("Vous avez choisi comme prénom : " + instancej.Joueurprenom);
		
		
		//Choix de la classe et Création Arme
		string Choix;
		string Possede = (".");
		do
		{
			Console.WriteLine("Vueillez choisir entre ces 3 classes : Chevalier, Barbare, Archer");
			Choix = Console.ReadLine();
			if (Choix == "Barbare") {
				instancej.additem(new Armes(40,"Hache"));
				Possede = ("Hache");
			}
			else if (Choix == "Chevalier") {
				instancej.additem(new Armes(20,"epee"));
				Possede = ("Epée");
			}
			else if (Choix == "Archer") {
				instancej.additem(new Armes(15,"Arc"));
				Possede = ("Arc"); }
			else
			{
				Console.WriteLine("Choisissez une classe existante");
			}
			}while(Choix!= "Chevalier" || Choix!= "Archer" || Choix!= "Barbare");
		
		//Mise en place des dégats
		
		if (Possede == ("Arc"))
		{
			degats = 15 ; 
		}
		if (Possede == ("Epée"))
		{
			degats = 20 ; 
		}
		if (Possede == ("Hache"))
		{
			degats = 40 ; 
		}

		//L'affichage des informations
		
		Console.WriteLine("*********************************************");
		Console.WriteLine("* Voici votre fiche personnage :            ");
		Console.WriteLine("* Votre Nom : " + instancej.NomJoueur);
		Console.WriteLine("* Votre Prénom : " + instancej.Joueurprenom);
		Console.WriteLine("* Vos point de vie sont : " + instancej.Nombrevie);
		Console.WriteLine("* Votre classe est : " + Choix);
		Console.WriteLine("* Votre arme est : " + Possede);
		Console.WriteLine("* Votre arme fait : " + degats);
		Console.WriteLine("*********************************************");
	//Pour le combats faire un readline ou il entrera attaque, et à chaque tour l'ennemie lui infligera un nombre de dégats définis jusqu'a ce que soit 
	//il meurt ou que l'ennemie meurt
		
	//Combats 
		Console.WriteLine("    ");
		Console.WriteLine("    ");
		Console.WriteLine("*****************************************************************************************************************************************");
		Console.WriteLine("* Histoire :");
		Console.WriteLine("* Vous êtes à la recherche d'une couronne mystique depuis plusieurs année.");
		Console.WriteLine("* Au périle de votre vie vous avez encouru de grand danger, reçu une multitude d'information");
		Console.WriteLine("* Vous finissez par recevoir l'information qu'un Orc détiendrait cette couronne vous partez donc à la recherche de cette couronne");
		Console.WriteLine("* Vous finissez après plsuieurs semaine a retourvez la trace de cet Orc et vous vous retrouvez en face de lui, son nom c'est Grimgor Boitenfer");
		Console.WriteLine("Deux choix s'offre à vous : le Combattre ou Fuir");
		string Debutcombat = Console.ReadLine();
		if (Debutcombat == "Fuir")
		{
			Console.WriteLine("----------------------------------------------------------");
			Console.WriteLine("Grimgor vous rattrape et vous massacre, vous êtes mort :c ");
			Console.WriteLine("                     GAME OVER                            ");
			Console.WriteLine("----------------------------------------------------------");
		}
		string PossedeGrim = (".");
		if(Debutcombat == "Combattre")
		{
				Console.WriteLine("----------------------------------------------------------");
				Console.WriteLine("Vous avez donc décidé de vous battre contre Grimgor !");
				Console.WriteLine("Grimgor : Cé moua lé Boss ! Cé moua quié la couronne !");
				Console.WriteLine("----------------------------------------------------------");
				instancej.addGrimgor(new Armes(50,"Hache de Grimgor"));
				PossedeGrim = ("Hache de Grimgor");
					if (PossedeGrim == ("Hache de Grimgor"))
					{
						degatsGrim = 50;
					}
			while (pvGrimgor != 0 || Nombrevie != 0)
			{
				Console.WriteLine("Grimgor ce prépare à attaquer, que faite vous ? Attaquer - ne rien faire");
				string Choix2 = Console.ReadLine();
				Console.WriteLine("Voulez vous voir vos information? entrez Oui ou entrez Non");
				string Statistique = Console.ReadLine();
				Console.WriteLine("Il vous reste : ", + pvGrimgor);
				do{
					if(Statistique == "Oui")
					{
							Console.WriteLine("*********************************************");
							Console.WriteLine("* Voici votre fiche personnage :            ");
							Console.WriteLine("* Votre Nom : " + instancej.NomJoueur);
							Console.WriteLine("* Votre Prénom : " + instancej.Joueurprenom);
							Console.WriteLine("* Vos point de vie sont : " + instancej.Nombrevie);
							Console.WriteLine("* Votre classe est : " + Choix);
							Console.WriteLine("* Votre arme est : " + Possede);
							Console.WriteLine("* Votre arme fait : " + degats);
							Console.WriteLine("*********************************************");
					}
					if(Statistique == "Non")
					{
						Console.WriteLine("Poursuite du combat !");
					}
				}while(Statistique != "Oui" || Statistique != "Non");
				
				if(Choix2 == "Attaquer")
				{
					Console.WriteLine("Vous attaquez");
					pvGrimgor = pvGrimgor - degats;
					Nombrevie = Nombrevie - degatsGrim;
				}
				if(Choix2 == "ne rien faire")
				{
					Nombrevie = Nombrevie - degatsGrim;
				}
				if(pvGrimgor == 0)
				{
					Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------");
					Console.WriteLine("Fin Victorieuse:");
					Console.WriteLine("Le combat fut rude et difficile mais vous voyez devant vous tomber le corps sans vie de Grimgor.");
					Console.WriteLine("Autrefois un combattant de légende il est aujourd'hui a vos pieds, sans vie");
					Console.WriteLine("A vos pied la couronne mystique, après tant d'années de recherche vous finissez par la trouver, votre calvère est terminé");
					Console.WriteLine("Alors que vous la posez sur votre tête vous sentez le pouvoir que vous confie cette couronne, vous avez réussis !");
					Console.WriteLine("           ");
					Console.WriteLine("                                            VICTOIRE c:                                                                   ");
					Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------");
					break;
				}
				if(Nombrevie == 0)
				{
					Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------");
					Console.WriteLine("Défaite:");
					Console.WriteLine("Le combat fut rude et difficile mais malgré tous, votre vision ce trouble suite au dernier coups porté par Grimgor.");
					Console.WriteLine("Vous sentez sa hache dans votre cou, vous vous écroulé à terre");
					Console.WriteLine("Alors que votre vision deviens noir vous voyez et entendez le rire de Grimgor");
					Console.WriteLine("Vous avez échouez!");
					Console.WriteLine("           ");
					Console.WriteLine("                                            Défaite :c                                                                   ");
					Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------");
					break;
				}
			} 
				
		}


	}
}

public class Personnages
{
    private string lieu;
    private int degats;
    protected int nombre_pv;
	protected string nom_joueur;
	protected string joueur_prenom;
	protected int BossOrc;
	
    public Personnages (string lieu2, int degats2, int nombre_pv2, string nom_joueur2, string joueur_prenom2, int BossOrc2) 
    {
        this.lieu = lieu2;
        this.degats = degats2;
        this.nombre_pv = nombre_pv2;
        this.nom_joueur = nom_joueur2;
		this.joueur_prenom = joueur_prenom2;
		this.BossOrc = BossOrc2;
	}
}


public class Joueurs : Personnages
{
    public List<Items> items = new List<Items>();
	public List<Items> Grimgorinventaire = new List<Items>();
    
    public Joueurs(string lieu2, int degats2, int nombre_pv2, string nom_joueur2, string joueur_prenom2, int BossOrc2) : base(lieu2, degats2, nombre_pv2, nom_joueur2, joueur_prenom2, BossOrc2)
    {
    }

    public string NomJoueur
    {
        get { return nom_joueur; }
        set { nom_joueur = value; }
    }
	public string Joueurprenom
    {
        get { return joueur_prenom; }
        set { joueur_prenom = value; }
    }
	public int Nombrevie
    {
        get { return nombre_pv; }
        set { nombre_pv = value; }
    }
	public int pvGrimgor
    {
        get { return BossOrc; }
        set { BossOrc = value; }
    }
	public void additem(Items weapon)
	{
	this.items.Add(weapon);
	}
	public void addGrimgor(Items weapon)
	{
	this.Grimgorinventaire.Add(weapon);
	}
}

public class Armes : Items   //Creation classe Armes
{
    private int degat ;
	
	private string nom;
    
    public Armes(int degat2, string nom)
    {
        this.degat = degat2;
		this.nom = nom;
    }
    public void setDegat(int degat3)
    {
        this.degat = degat3;
    }
    public double getDegat()
    {
        return this.degat;
    }
}

public class Items
{

}

public class ennemies : Personnages
{
    public ennemies (string lieu2, int degats2, int nombre_pv2, string nom_joueur2, string joueur_prenom2, int BossOrc2) : base(lieu2, degats2, nombre_pv2, nom_joueur2, joueur_prenom2, BossOrc2)
    {
	
    }
}