

///// faire l'héritage de ARmure dans Items -----> rajouter private int armure bronze, int armure fer et int armure cuire

public class Armure : Items       //Création Armes hérite de Items
{
    private int protection;
    private string nom;

    public Armures(int protection2, string nom2)
    {

        this.protection = protection2;
        this.nom = nom2;
    }
}