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