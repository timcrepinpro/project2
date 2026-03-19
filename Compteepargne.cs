class CompteEpargne : Compte
{
    private string dateouverture;
    private double tauxInteret;
    

    public CompteEpargne(string nom, double solde ,string dateOuverture, double tauxInteret ) : base(nom, solde)
    {
        this.dateouverture = dateOuverture;
        this.tauxInteret = tauxInteret;
        
    }
    public double getinteret()
    {
        return this.tauxInteret;
    }
    public string getdate()
    {
        return this.dateouverture;
    
    }
    public void setinteret(double tauxInteret)
    {
        this.tauxInteret = tauxInteret;
    }
    public void setdate(string dateOuverture)
    {
        this.dateouverture = dateOuverture;
    }
    public void afficher()
    {
        Console.WriteLine("le taux d'interet de votre compte epargne est de " + this.tauxInteret + " et la date d'ouverture est " + this.dateouverture);
    }

    public void depot(int montant)
    {
        this.solde += montant;
        Console.WriteLine("depot: " + montant + " \nsolde: " + this.solde);
    }
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
        public void transfert(Compte destinataire, double montant)
    {
        if(this.solde < montant+200)
        {
            Console.WriteLine("solde insuffisant pour effectuer le transfert de " + montant);
            return;
        }
        this.solde -= montant;
        destinataire.depot((int)montant);
        Console.WriteLine($"votre capital actuel est de {this.solde}");
        Console.WriteLine("transfert de " + montant + " effectué vers le compte de " + destinataire.GetNom());
        
    }
   
}