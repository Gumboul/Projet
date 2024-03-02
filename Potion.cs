public class Potion : Items  //Creation classe Potion
{
    private int valeur ;

    
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
}

public class Soin:Potion     //Creation classe Soin
{
    public Soin():base(10)
    {
        Soin.augmenter(valeur)
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