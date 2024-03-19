using System;
using System.Collections.Generic;
					
public class Projet
{
	public static void Main()
	{
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.Write("Entrez le nom du joueur : ");
        string Joueurs1 = Console.ReadLine();

        Joueurs instance = new Joueurs("lieu", 0, 100, Joueurs1);
        Console.WriteLine("Le nom de votre joueur est : " + instance.NomJoueur);
	}
}

public class Personnages : Projet
{
    private string lieu;
    private int degats;
    private int nombre_pv;
	protected string nom_joueur;
    public Personnages (string lieu2, int degats2, int nombre_pv2, string nom_joueur2) 
    {
        this.lieu = lieu2;
        this.degats = degats2;
        this.nombre_pv = nombre_pv2;
        this.nom_joueur = nom_joueur2;
	}
}


public class Joueurs : Personnages
{
    public List<string> Items = new List<string>();
    
    public Joueurs(string lieu2, int degats2, int nombre_pv2, string nom_joueur2) : base(lieu2, degats2, nombre_pv2, nom_joueur2)
    {
    }

    public string NomJoueur
    {
        get { return nom_joueur; }
        set { nom_joueur = value; }
    }
}