using System.ComponentModel;

namespace project2;


class Compte
{
    private int numero;
    private string nom;
    private double solde;
    private static int nombreComptes = 0;

    public Compte( string nom, double solde)
    {
        this.numero = nombreComptes;
        this.nom = nom;
        this.solde = solde;
        nombreComptes++;
    }
    public void affichersolde()
    {
        Console.WriteLine("le solde du compte de " + this.nom + " est: " + this.solde);
    }

    public void retrait(int montant)
    {   
        if(this.solde < montant-200)
        {
            Console.WriteLine("solde insuffisant pour effectuer le retrait de " + montant);
            return;
        }
        this.solde -= montant;
        Console.WriteLine("retrait de " + montant + " effectué, solde actuel: " + this.solde);
    }
    public void transfert(Compte destinataire, double montant)
    {
        if(this.solde < montant-200)
        {
            Console.WriteLine("solde insuffisant pour effectuer le transfert de " + montant);
            return;
        }
        this.solde -= montant;
        destinataire.solde += montant;
        Console.WriteLine($"votre capital actuel est de {this.solde}");
        Console.WriteLine("transfert de " + montant + " effectué vers le compte de " + destinataire.nom);
    }
   

}
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Compte compte1 = new Compte("Alice", 500);
        Compte compte2 = new Compte("Bob", 1000);
        Compte compte3 = new Compte("charlie", 1);
        Compte compte4 = compte1;

        compte4.retrait(100);

        compte1.affichersolde();
        compte2.transfert(compte3, 200);


    }
}
