public class Armure : Items //Creation classe Armure
{
    private int protection ;

    public Armure(int protection2)
    {
        this.protection = protection2;
    }
    public void setProtection(int protection3)
    {
        this.protection = protection3;
    }
    public double getProtection()
    {
        return this.protection;
    }

    public Armure(int ajout2)
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

public class Casque:Armure     //Creation classe Casque
{
    private Casque():base(5)
    {
            Casque.augmenter(ajout)
            {
                Personnages.nombre_pv = Personnages.nombre_pv + Casque;
            }
    }
}

public class Epaulettes:Armure     //Creation classe Epaulettes
{
    private Epaulettes():base(5)
    {
            Epaulettes.augmenter(ajout)
            {
                Personnages.nombre_pv = Personnages.nombre_pv + Epaulettes;
            }
    }
}

public class Jambieres:Armure     //Creation classe Jambieres
{
    private Jambieres():base(10)
    {
            Jambieres.augmenter(ajout)
            {
                Personnages.nombre_pv = Personnages.nombre_pv + Jambieres;
            }
    }
}

public class Bottes:Armure     //Creation classe Bottes
{
    private Bottes():base(5)
    {
    Bottes.augmenter(ajout)
        {
            Personnages.nombre_pv = Personnages.nombre_pv + Bottes;
        }
    }
}

public class Gantelet:Armure     //Creation classe Bottes
{
    private Gantelet():base(5)
    {
            Gantelet.augmenter(ajout)
            {
                Personnages.nombre_pv = Personnages.nombre_pv + Gantelet;
            }
    }
}