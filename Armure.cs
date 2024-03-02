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
    
}

public class Casque:Armure     //Creation classe Casque
{
    private Casque():base(5)
    {
        Personnages.nombre_pv = Personnages.nombre_pv + Casque;
    }
}

public class Epaulettes:Armure     //Creation classe Epaulettes
{
    private Epaulettes():base(5)
    {
        Personnages.nombre_pv = Personnages.nombre_pv + Epaulettes;
    }
}

public class Jambieres:Armure     //Creation classe Jambieres
{
    private Jambieres():base(10)
    {
        Personnages.nombre_pv = Personnages.nombre_pv + Jambieres;
    }
}

public class Bottes:Armure     //Creation classe Bottes
{
    private Bottes():base(5)
    {
        Personnages.nombre_pv = Personnages.nombre_pv + Bottes;
    }
}

public class Gantelet:Armure     //Creation classe Bottes
{
    private Gantelet():base(5)
    {
        Personnages.nombre_pv = Personnages.nombre_pv + Gantelet;
    }
}