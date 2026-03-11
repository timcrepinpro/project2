using System.ComponentModel;
using math = System.Math;

namespace project2;


class Compte
{
    private int numero;
    private string nom;
    private double solde;
    private float endettement;
    private static int nombreComptes = 0;

    public Compte( string nom, double solde)
    {
        this.numero = nombreComptes;
        this.nom = nom;
        this.solde = solde;
        this.endettement = 0;
        nombreComptes++;
    }

    // affiche le solde du compte
    public void affichersolde()
    {
        Console.WriteLine("le solde du compte de " + this.nom + " est: " + this.solde);
    }

    // effectue un retrait du montant spécifié si le solde est suffisant, sinon affiche un message d'erreur
    //affiche le solde actuel après le retrait
    public void retrait(int montant)
    {   
        if(this.solde < montant+200)
        {
            Console.WriteLine("solde insuffisant pour effectuer le retrait de " + montant);
            return;
        }
        this.solde -= montant;
        Console.WriteLine("retrait de " + montant + " effectué, solde actuel: " + this.solde);
    }
    // effectue un transfert du montant spécifié vers le compte destinataire si le solde est suffisant, sinon affiche un message d'erreur
    // affiche le solde actuel après le transfert
    public void transfert(Compte destinataire, double montant)
    {
        if(this.solde < montant+200)
        {
            Console.WriteLine("solde insuffisant pour effectuer le transfert de " + montant);
            return;
        }
        this.solde -= montant;
        destinataire.solde += montant;
        Console.WriteLine($"votre capital actuel est de {this.solde}");
        Console.WriteLine("transfert de " + montant + " effectué vers le compte de " + destinataire.nom);
    }
   
    // effectue un emprunt du montant spécifié si le montant total de l'endettement après l'emprunt ne dépasse pas 33% du solde, sinon affiche un message d'erreur
    public void endetter(float montant)
    {
        if(montant+this.endettement < this.solde*0.33-this.endettement)
        {
            this.endettement += (float)Math.Round(montant * 1.03);
            this.solde += montant;
            Console.WriteLine($" taux pret : 1.03 \nempreint : {montant} \n endettement : {this.endettement} \n capital actuel : {this.solde}");
        }
    }
    // effectue un remboursement du montant spécifié si le montant est inférieur à l'endettement, sinon affiche un message d'erreur
    public void rembourser(float montant)
    {
        if(montant > this.endettement)
        {
            Console.WriteLine("le montant à rembourser est supérieur à l'endettement actuel");
            return;
        }
        if(montant > this.solde)
        {
            Console.WriteLine("le montant à rembourser est supérieur au solde actuel");
            return;
        }
        this.endettement -= montant;
        this.solde -= montant;
        Console.WriteLine($"remboursement de {montant} effectué \nendettement actuel: {this.endettement} \nsolde actuel: {this.solde}");
    }

    // affiche le montant total de l'endettement du compte
    public void afficherendettement()
    {
        Console.WriteLine("personne : " + this.nom + "\nendetement: " + this.endettement);
    }

}
class Program
{
    static void Main(string[] args)
    {
        
        Compte compte1 = new Compte("Alice", 2000);
        Compte compte2 = new Compte("Bob", 1000);
        Compte compte3 = new Compte("charlie", 1);
        Compte compte4 = compte1;

        compte4.retrait(100);

        compte1.affichersolde();
        compte2.transfert(compte3, 200);

        compte1.endetter(500);
        compte1.afficherendettement();
        compte1.rembourser(200);
        compte1.afficherendettement();


    }
}
