using System.Collections.Generic;

namespace Academy.Entitys;

public class Group
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Student> Students { get; set; } = new();

}