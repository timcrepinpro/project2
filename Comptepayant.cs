using System.ComponentModel;

class Comptepayant : Compte
{
    private double commission;
    private int nombreoperations;
    public Comptepayant(string nom, double solde, double commission, int nombreoperations) : base(nom, solde)
    {
    this.commission = commission;
    this.nombreoperations = nombreoperations;
    }
    public void setcommission(double commission)
    {
        this.commission = commission;
    }
    public void setnombreoperations(int nombreoperations)
    {
        this.nombreoperations = nombreoperations;
    }
    public double getcommission()
    {
        return this.commission;
    }
    public int getnombreoperations()
    {
        return this.nombreoperations;
    }
    public void afficher()
    {
        Console.WriteLine(" le nombre d'operations effectuées sur votre compte payant est de " + this.nombreoperations + " et la commission est de " + this.commission);
    }
    public void depot(int montant)
    {
        double montantaveccommission = montant - (montant * this.commission);
        this.solde += montantaveccommission;
        this.nombreoperations++;
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
        this.nombreoperations++;
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
        this.nombreoperations++;
    }

}


