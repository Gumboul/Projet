public class Potion : Items  //Creation classe Potion
{
    private int valeur ;
    private int ajout;

    
    public Potion(int valeur2)
    {
        this.valeur = valeur2;
    }
    public void setValeur(int valeur3)
    {
        this.valeur = valeur3;
    }
    public double getValeur()
    {
        return this.valeur;
    }

        public Potion(int ajout2)
    {
        this.ajout = ajout2;
    }
    public void setValeur(int ajout3)
    {
        this.ajout = ajout3;
    }
    public double getValeur()
    {
        return this.ajout;
    }
}

public class Soin:Potion     //Creation classe Soin
{
    public Soin():base(10)
    {
        Soin.augmenter(valeur)
        {
            Personnages.nombre_pv = Personnages.nombre_pv + Soin;
        }
    }
}
public class Force : Potion     //Creation classe Soin
{
    public Force():base(10)
    {
        Force.augmenter(ajout)
        {
            Personnages.nombre_pv = Personnages.nombre_pv + Force;
        }
    }
}






public class Soin:Potion
{
	public int Augmenter()

	{
	    int	description	=	"Le	solde	du	compte	de	"	+		titulaire	+	"	est	de	"	+	sold
e	+	"	"	+	devise;
								return	description;
				}
}