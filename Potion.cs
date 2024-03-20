public class Potion   //Creation classe Potion
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


public class Potion : Items       //Création Potion hérite dans Items
{
    private int soin;
    private int force;

    public Potion(int soin, int force)
    {
        this.soin = soin;
        this.force = force;
    }

    public int getSoin()
    {
        return this.soin
    }

    public void setSoin(10)
    {
       
    }

    public int getForce()
    {
        return this.force
    }

    public void setForce(10)
    {
        
    }

}




public class Force : Potion     //Creation héritage force - potion
{
    public Force():base(10)
    {
        this.augmenter(valeur)
    }
}


public class Soin : Potion     //Creation héritage soin : potion
{
    public Soin():base(10)
    {
    
    }
}



public class Potion   //création de la méthode
{
    public string ()
    {
        int augmentation = "On augmente de " + pv + pa + "au joueur" + personnages;

        return augmentation
    }
}
 
public class Potion  // cretion d'objet
{
    public int Pova()
    {
        Potion Pova = new Pova()
    }
}






public class Point    //Création de l'objet
{
    public int Point { get.Potion; set(int 10); }
    public Augmenter(int Point)
    {
        Point instance = new Point
    }
    // Other properties, methods, events...
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