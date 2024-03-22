using System;
using System.Collections.Generic;

public class Projet
{
    public static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        // Le nom et prénom de votre joueur

        Console.Write("Entrez le nom du joueur : ");
        string Joueursnom = Console.ReadLine();
        Console.WriteLine("Entrez le prénom de votre joueur :");
        string Joueurprenom = Console.ReadLine();
        int Nombrevie = 200;
        int pvGrimgor = 300;
        int degats = 0;
        int degatsGrim = 0;
        Joueurs instancej = new Joueurs("lieu", 0, Nombrevie, Joueursnom, Joueurprenom, pvGrimgor);
		ennemies instancee = new ennemies("lieu", 0, Nombrevie, Joueursnom, Joueurprenom, pvGrimgor);
        Console.WriteLine("Vous avez choisi comme nom : " + instancej.NomJoueur);
        Console.WriteLine("Vous avez choisi comme prénom : " + instancej.Joueurprenom);

        // Choix de la classe et Création Arme
        string Choix;
        bool verif = false;
        string Possede = (".");
        string Protection = (".");
        do
        {
            Console.WriteLine("Vueillez choisir entre ces 3 classes : Chevalier, Barbare, Archer");
            Choix = Console.ReadLine();
            if (Choix == "Barbare")
            {
                instancej.additem(new Armes(40, "Hache"));
                instancej.addArmure(new Armures(100, "Armure en Bronze"));
                Possede = ("Hache");
                Protection = ("Armure en Bronze");
                verif = true;
            }
            else if (Choix == "Chevalier")
            {
                instancej.additem(new Armes(20, "epee"));
                instancej.addArmure(new Armures(150, "Armure en Fer"));
                Possede = ("Epée");
                Protection = ("Armure en Fer");
                verif = true;
            }
            else if (Choix == "Archer")
            {
                instancej.additem(new Armes(15, "Arc"));
                instancej.addArmure(new Armures(50, "Armure en Cuir"));
                Possede = ("Arc");
                Protection = ("Armure en Cuir");
                verif = true;
            }
            else
            {
                Console.WriteLine("Choisissez une classe existante");
            }
        } while (verif == false);
        verif = false;

        // Mise en place de la vie suite aux armures

        if (Protection == ("Armure en Bronze"))
        {
            instancej.setNombrevie(100);
        }
        if (Protection == ("Armure en Fer"))
        {
            instancej.setNombrevie(150);
        }
        if (Protection == ("Armure en Cuir"))
        {
            instancej.setNombrevie(50);
        }

        // Mise en place des dégats
        if (Possede == ("Arc"))
        {
            degats = 15;
        }
        if (Possede == ("Epée"))
        {
            degats = 20;
        }
        if (Possede == ("Hache"))
        {
            degats = 400;
        }

        // L'affichage des informations

        Console.WriteLine("*********************************************");
        Console.WriteLine("* Voici votre fiche personnage :            ");
        Console.WriteLine("* Votre Nom : " + instancej.NomJoueur);
        Console.WriteLine("* Votre Prénom : " + instancej.Joueurprenom);
        Console.WriteLine("* Vos points de vie initiaux sont : 200");
        Console.WriteLine("* Vos point de vie avec Armure sont : " + instancej.getNombrevie());
        Console.WriteLine("* Votre classe est : " + Choix);
        Console.WriteLine("* Votre arme est : " + Possede);
        Console.WriteLine("* Votre arme fait : " + degats);
        Console.WriteLine("* Votre Armure est : " + Protection);
        Console.WriteLine("*********************************************");

        // Combats
        Console.WriteLine("    ");
        Console.WriteLine("    ");
        Console.WriteLine("*****************************************************************************************************************************************");
        Console.WriteLine("* Histoire :");
        Console.WriteLine("* Vous êtes à la recherche d'une couronne mystique depuis plusieurs année.");
        Console.WriteLine("* Au périle de votre vie vous avez encouru de grand danger, reçu une multitude d'information");
        Console.WriteLine("* Vous finissez par recevoir l'information qu'un Orc détiendrait cette couronne vous partez donc à la recherche de cette couronne");
        Console.WriteLine("* Vous finissez après plsuieurs semaine a retourvez la trace de cet Orc et vous vous retrouvez en face de lui, son nom c'est Grimgor Boitenfer");
        Console.WriteLine("Deux choix s'offre a vous : le Combattre ou Fuir");
        string Debutcombat = Console.ReadLine();
        if (Debutcombat == "Fuir")
        {
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("Grimgor vous rattrape et vous massacre, vous êtes mort :c ");
            Console.WriteLine("                     GAME OVER                            ");
            Console.WriteLine("----------------------------------------------------------");
        }
        string PossedeGrim = (".");
        if (Debutcombat == "Combattre")
        {
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("Vous avez donc décidé de vous battre contre Grimgor !");
            Console.WriteLine("Grimgor : Cé moua lé Boss ! Cé moua quié la couronne !");
            Console.WriteLine("----------------------------------------------------------");
            instancee.addGrimgor(new Armes(50, "Hache de Grimgor"));
            PossedeGrim = ("Hache de Grimgor");
            if (PossedeGrim == ("Hache de Grimgor"))
            {
                degatsGrim = 50;
            }
            while (instancee.getpvGrimgor() != 0 ||instancee.getpvGrimgor() !< 0 || instancej.getNombrevie() != 0 || instancej.getNombrevie() !< 0)
{
    Console.WriteLine("Il reste : " + instancee.getpvGrimgor() + " à Grimgor");
    Console.WriteLine("Grimgor se prépare à attaquer, que faites-vous ? Attaquer - ne rien faire");
	string Choix2 = Console.ReadLine();
    Console.WriteLine("Voulez-vous voir vos informations ? Entrez Oui ou entrez Non");
    string Statistique = Console.ReadLine();

    if (Statistique == "Oui")
    {
        Console.WriteLine("*********************************************");
        Console.WriteLine("* Voici votre fiche personnage :            ");
        Console.WriteLine("* Votre Nom : " + instancej.NomJoueur);
        Console.WriteLine("* Votre Prénom : " + instancej.Joueurprenom);
        Console.WriteLine("* Vos points de vie sont : " + instancej.getNombrevie());
        Console.WriteLine("* Votre classe est : " + Choix);
        Console.WriteLine("* Votre arme est : " + Possede);
        Console.WriteLine("* Votre arme fait : " + degats);
        Console.WriteLine("*********************************************");
    }
    else if (Statistique == "Non")
    {
        Console.WriteLine("Poursuite du combat !");
    }

    if (Choix2 == "Attaquer")
    {
        Console.WriteLine("Vous attaquez");
        // Perte de pv Grimgor
        instancee.diminutionpvGrimgor(degats);
        // Perte PV personnages
        instancej.diminutionNombrevie(degatsGrim);
    }
    else if (Choix2 == "ne rien faire")
    {
        instancej.diminutionNombrevie(degatsGrim);
    }

    if (instancee.getpvGrimgor() == 0 ||instancee.getpvGrimgor() !< 0)
    {
        Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------");
        Console.WriteLine("Fin Victorieuse:");
        Console.WriteLine("Le combat fut rude et difficile mais vous voyez devant vous tomber le corps sans vie de Grimgor.");
        Console.WriteLine("Autrefois un combattant de légende il est aujourd'hui a vos pieds, sans vie");
        Console.WriteLine("A vos pied la couronne mystique, après tant d'années de recherche vous finissez par la trouver, votre calvère est terminé");
        Console.WriteLine("Alors que vous la posez sur votre tête vous sentez le pouvoir que vous confie cette couronne, vous avez réussis !");
        Console.WriteLine("           ");
        Console.WriteLine("                                            VICTOIRE c:                                                                   ");
        Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------");
        break;
    }
    else if (instancej.getNombrevie() == 0|| instancej.getNombrevie() !< 0)
    {
        Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------");
        Console.WriteLine("Défaite:");
        Console.WriteLine("Le combat fut rude et difficile mais malgré tous, votre vision ce trouble suite au dernier coups porté par Grimgor.");
        Console.WriteLine("Vous sentez sa hache dans votre cou, vous vous écroulé à terre");
        Console.WriteLine("Alors que votre vision deviens noir vous voyez et entendez le rire de Grimgor");
        Console.WriteLine("Vous avez échoué!");
        Console.WriteLine("           ");
        Console.WriteLine("                                            Défaite :c                                                                   ");
        Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------");
        break;
    }
}
		}
}