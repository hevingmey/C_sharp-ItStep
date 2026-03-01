namespace Academy.Entitys;

public class Grade
{
    public int Id { get; set; }
    public int? value { get; set; }
    public int studentId { get; set; }
    public int subjectId { get; set; }
    public DateTime dateAsigned { get; set; }
    public Student student { get; set; } = null!;
    public Subject subject { get; set; } = null!;
}