public class Joueurs : Personnages
{
    public List<Items> items = new List<Items>();
    
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
	public void additem(Items weapon)
	{
	this.items.Add(weapon);
	}

    public static Personnages 
    {
        joueur.zone(Lieu)
        {

        } 
    }
    public static Personnages
    {
        joueur.fouille(Zone)
        {
            
        }
    }
}