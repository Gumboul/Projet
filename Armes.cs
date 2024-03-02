public class Armes : Items   //Creation classe Armes
{
    private int degat ;

    
    public Armes(int degat2)
    {
        this.degat = degat2;
    }
    public void setDegat(int degat3)
    {
        this.degat = degat3;
    }
    public double getDegat()
    {
        return this.degat;
    }
}

public class Epee:Armes   //Creation classe Epee 
{
    public Epee():base(20)
    {
        
    }
}

public class Masse:Armes     //Creation classe Masse
{
    public Masse():base(40)
    {
        
    }
}