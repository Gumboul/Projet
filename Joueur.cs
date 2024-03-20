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

    public int getNombrevie()
    {
        return this.nombre_pv;
    }

    public void setNombrevie(int i)
    {
        this.nombre_pv = this.nombre_pv + i;
    }

    public void diminutionNombrevie(int i)
    {
        this.nombre_pv = this.nombre_pv - i;
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

    public void additem(Items weapon)
    {
        this.items.Add(weapon);
    }

    public void addArmure(Items Armures)
    {
        this.items.Add(Armures);
    }

    public void addGrimgor(Items weapon)
    {
        this.Grimgorinventaire.Add(weapon);
    }
}