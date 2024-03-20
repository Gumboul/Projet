public class Armes : Items   //Creation classe Armes
{
    private int degat;

    private string nom;

    public Armes(int degat2, string nom)
    {
        this.degat = degat2;
        this.nom = nom;
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