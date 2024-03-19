public class Projet
{
	public static void Main()
	{
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.Write("Entrez le nom du joueur : ");
        string Joueurs1 = Console.ReadLine();

        Joueurs instance = new Joueurs("lieu", 0, 100, Joueurs1);
        Console.WriteLine("Le nom de votre joueur est : " + instance.NomJoueur);
	}
}