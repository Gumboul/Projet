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
		int Nombrevie = 100;
        Joueurs instancej = new Joueurs("lieu", 0, Nombrevie, Joueursnom, Joueurprenom);
        Console.WriteLine("Vous avez choisi comme nom : " + instancej.NomJoueur);
		Console.WriteLine("Vous avez choisi comme prénom : " + instancej.Joueurprenom);
		
		
		//L'affichage des informations
		
		Console.WriteLine("*********************************************");
		Console.WriteLine("* Voici votre fiche personnage :            ");
		Console.WriteLine("* Votre Nom : " + instancej.NomJoueur);
		Console.WriteLine("* Votre Prénom : " + instancej.Joueurprenom);
		Console.WriteLine("* Vos point de vie sont : " + instancej.Nombrevie);
	
	}
}

public class Personnages : Projet
{
    private string lieu;
    private int degats;
    protected int nombre_pv;
	protected string nom_joueur;
	protected string joueur_prenom;
    public Personnages (string lieu2, int degats2, int nombre_pv2, string nom_joueur2, string joueur_prenom2) 
    {
        this.lieu = lieu2;
        this.degats = degats2;
        this.nombre_pv = nombre_pv2;
        this.nom_joueur = nom_joueur2;
		this.joueur_prenom = joueur_prenom2;
	}
}


public class Joueurs : Personnages
{
    public List<string> Items = new List<string>();
    
    public Joueurs(string lieu2, int degats2, int nombre_pv2, string nom_joueur2, string joueur_prenom2) : base(lieu2, degats2, nombre_pv2, nom_joueur2, joueur_prenom2)
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
}