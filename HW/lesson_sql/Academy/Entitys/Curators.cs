namespace Academy.Entitys;

public class Curators
{
    public int id { get; set; }
    public string name { get; set; }= string.Empty;
    public string surname { get; set; } = string.Empty;
    public Group group{get;set;}
}