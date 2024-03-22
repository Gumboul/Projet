public class ennemies : Personnages
{
	public List<Items> Grimgorinventaire = new List<Items>();
    public ennemies(string lieu2, int degats2, int nombre_pv2, string nom_joueur2, string joueur_prenom2, int BossOrc2) : base(lieu2, degats2, nombre_pv2, nom_joueur2, joueur_prenom2, BossOrc2)
    {

    }
	 public int getpvGrimgor()
    {
        return this.BossOrc;
    }

    public void setpvGrimgor(int i)
    {
        this.BossOrc = this.BossOrc + i;
    }

    public void diminutionpvGrimgor(int i)
    {
        this.BossOrc = this.BossOrc - i;
    }
	    public void addGrimgor(Items weapon)
    {
       this.Grimgorinventaire.Add(weapon);
    }
}