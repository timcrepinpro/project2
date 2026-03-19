class Compte
{
    protected int numero;
    protected string nom;
    protected double solde;
    
    protected static int nombreComptes = 0;

    public string GetNom()
    {
        return this.nom;
    }

    public Compte()
    {
        
    }
    public Compte( string nom, double solde)
    {
        this.numero = nombreComptes;
        this.nom = nom;
        this.solde = solde;
        
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
        // effectue un dépôt du montant spécifié et affiche le solde actuel après le dépôt
    public void depot(int montant)
    {
        this.solde += montant;
        Console.WriteLine("depot: " + montant + " \nsolde: " + this.solde);
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

}