// Sale sale = new Sale();
// var sale = new Sale();
Sale sale = new(15);
string message = sale.GetInfo();
Console.WriteLine(message);

class SaleWithTax : Sale
{
    public SaleWithTax(decimal total) : base(total)
    {
        
    }
}

class Sale
{
    public decimal Total { get; set; }
    private decimal _some;

    public Sale(decimal total)
    {
        this.Total = total;
    }

    public string GetInfo()
    {
        return "El Total es: " + this.Total;
    }
}
