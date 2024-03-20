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

///// faire l'héritage de ARmure dans Items -----> rajouter private int armure bronze, int armure fer et int armure cuire

public class Armure : Items       //Création Armes hérite de Items
{
    private int armure_bronze;
    private int armure_fer;
    private int amure_cuire

    public Armure(int armure_bronze, int armure_fer, int armure_cuire)
    {
        this.armure_bronze = armure_bronze;
        this.armure_fer = armure_fer;
        this.armure_cuire = armure_cuire;
    }

    public int getArmure_bronze()
    {
        return this.armure_bronze
    }

    public void setArmure_bronze(5)
    {
       
    } 

    public int getArmure_fer()
    {
        return this.armure_fer
    }

    public void setArmure_fer(10)
    {
        
    }

    public int getArmure_cuire()
    {
        return this.armure_cuire
    }

    public void setArmure_cuire(15)
    {
        
    }

}

public class Armure : Items    //Création Armure hérite de Items
{
    public Armure():
    {

    }
}

public class Potions : Items    //Création potions hérite de Items
{
    public Potions()
    {

    }
}