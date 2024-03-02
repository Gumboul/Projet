public class Armure  //Creation classe Armure
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
        
    }
}

public class Epaulettes:Armure     //Creation classe Epaulettes
{
    private Epaulettes():base(5)
    {
        
    }
}

public class Jambieres:Armure     //Creation classe Jambieres
{
    private Jambieres():base(10)
    {
        
    }
}

public class Bottes:Armure     //Creation classe Bottes
{
    private Bottes():base(5)
    {
        
    }
}