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