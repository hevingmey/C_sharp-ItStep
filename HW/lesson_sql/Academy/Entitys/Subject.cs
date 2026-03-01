namespace Academy.Entitys;

public class Subject
{
    public int Id { get; set; }
    public string Name { get; set; }
    // public ICollection<Student> students{get;set;}=new List<Student>();
    public List<Grade> Grades { get; set; } = new();
    
}