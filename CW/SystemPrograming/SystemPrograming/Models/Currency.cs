namespace SystemPrograming;

public class Currency
{
    public int r030{get;set;}
    public string txt{get;set;}
    public decimal rate{get;set;}


    public override string ToString()
    {
        return $"Currency{txt}, Rate{rate}";
    }
}