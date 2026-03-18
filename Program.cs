using System.ComponentModel;
using math = System.Math;

namespace project2;



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
        compte3.depot(99999999);


    }
}
