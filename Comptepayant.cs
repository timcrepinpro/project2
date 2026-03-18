class Comptepayant : Compte
{
    private double commission;
    private int nombreoperations;

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

}
