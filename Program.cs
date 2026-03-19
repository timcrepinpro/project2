using System.ComponentModel;
using math = System.Math;

namespace project2;



class Program
{
    static void Main(string[] args)
    {
        
        Compte compte1 = new Compte("Alice", 2000);
        Compte compte2 = new Compte("Bob", 1000);
        
        Compte compte4 = compte1;

        compte4.retrait(100);

        compte1.affichersolde();
        
        Comptepayant compte5 = new Comptepayant("david", 500, 0.05, 10);
        compte5.depot(500);
        compte5.affichersolde();




        

        Compte compte3 = new Compte("farid", 1500);
        compte3.depot(200);
        compte3.retrait(400);
        compte3.affichersolde();
        CompteEpargne compte6 = new CompteEpargne("gina", 1000, "15/01/2024", 0.03);
        compte6.affichersolde();
        compte6.depot(150);
        compte6.retrait(300);
        compte6.retrait(1000);
        compte6.affichersolde();
        Comptepayant compte7 = new Comptepayant("hugo",700,3,0);
        compte7.affichersolde();
        compte7.depot(100);
        compte7.retrait(200);
        compte7.affichersolde();
        Console.WriteLine($"Nombre d'opérations sur le compte de {compte7.GetNom()} : {compte7.getnombreoperations()}");

        compte3.transfert(compte6, 100);
        compte6.transfert(compte7, 50);
        compte7.transfert(compte3, 2000);

    }
}
