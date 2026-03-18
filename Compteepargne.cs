class CompteEpargne 
{
    private int dateouverture;
    private double tauxInteret;
    

    public CompteEpargne(int dateOuverture, double tauxInteret )
    {
        this.dateouverture = dateOuverture;
        this.tauxInteret = tauxInteret;
        
    }
    public double getinteret()
    {
        return this.tauxInteret;
    }
    public int getdate()
    {
        return this.dateouverture;
    
    }
    public void setinteret(double tauxInteret)
    {
        this.tauxInteret = tauxInteret;
    }
    public void setdate(int dateOuverture)
    {
        this.dateouverture = dateOuverture;
    }
    public void afficher()
    {
        Console.WriteLine("le taux d'interet de votre compte epargne est de " + this.tauxInteret + " et la date d'ouverture est " + this.dateouverture);
    }


   
}